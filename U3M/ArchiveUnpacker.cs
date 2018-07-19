using BinderTool.Core;
using BinderTool.Core.Bdt5;
using BinderTool.Core.Bhd5;
using BinderTool.Core.Dcx;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace U3M
{
    class ArchiveUnpacker
    {
        private const long SPACE_REQUIRED = 1024L * 1024 * 1024 * 24;
        private static readonly Encoding ASCII = Encoding.ASCII;

        private bool stop;
        private string gameDir;
        private bool doData1, doData2, doData3, doData4, doData5, doDLC1, doDLC2;

        public bool Success { get; private set; }
        public string Status { get; private set; }
        public string Error { get; private set; }
        public Progress Data1Progress { get; private set; }
        public Progress Data2Progress { get; private set; }
        public Progress Data3Progress { get; private set; }
        public Progress Data4Progress { get; private set; }
        public Progress Data5Progress { get; private set; }
        public Progress DLC1Progress { get; private set; }
        public Progress DLC2Progress { get; private set; }

        public ArchiveUnpacker(string gameDir, bool doData1, bool doData2, bool doData3, bool doData4, bool doData5, bool doDLC1, bool doDLC2)
        {
            stop = false;
            this.gameDir = gameDir;
            this.doData1 = doData1;
            this.doData2 = doData2;
            this.doData3 = doData3;
            this.doData4 = doData4;
            this.doData5 = doData5;
            this.doDLC1 = doDLC1;
            this.doDLC2 = doDLC2;
            Data1Progress = new Progress();
            Data2Progress = new Progress();
            Data3Progress = new Progress();
            Data4Progress = new Progress();
            Data5Progress = new Progress();
            DLC1Progress = new Progress();
            DLC2Progress = new Progress();
        }

        public Thread Start()
        {
            Thread thread = new Thread(unpackAll);
            thread.Start();
            return thread;
        }

        public void Stop()
        {
            Status = "Stopping...";
            stop = true;
        }

        private void unpackAll()
        {
            string drive = Path.GetPathRoot(Path.GetFullPath(gameDir));
            DriveInfo driveInfo = new DriveInfo(drive);

            if (driveInfo.AvailableFreeSpace < SPACE_REQUIRED)
            {
                Success = false;
                Error = "At least 25 GB of free space is required to unpack the game.";
            }
            else
            {
                Success = backupSound()
                    && (!doData1 || unpackBDT("Data1", ArchiveKeys.Data1, Data1Progress, true))
                    && (!doData2 || unpackBDT("Data2", ArchiveKeys.Data2, Data2Progress, true))
                    && (!doData3 || unpackBDT("Data3", ArchiveKeys.Data3, Data3Progress, true))
                    && (!doData4 || unpackBDT("Data4", ArchiveKeys.Data4, Data4Progress, true))
                    && (!doData5 || unpackBDT("Data5", ArchiveKeys.Data5, Data5Progress, true))
                    && (!doDLC1 || unpackBDT("DLC1", ArchiveKeys.DLC1, DLC1Progress, false))
                    && (!doDLC2 || unpackBDT("DLC2", ArchiveKeys.DLC2, DLC2Progress, false));
            }

            if (stop)
                Status = "Unpacking stopped.";
            else
                Status = "Done unpacking!";
        }

        private bool backupSound()
        {
            string soundDir = gameDir + "\\sound";
            if (!Directory.Exists(soundDir + "-bak"))
            {
                try
                {
                    Directory.CreateDirectory(soundDir + "-bak");
                    foreach (string file in Directory.GetFiles(soundDir))
                    {
                        string name = Path.GetFileName(file);
                        File.Copy(file, soundDir + "-bak\\" + name);
                    }
                }
                catch (Exception ex)
                {
                    Error = "Failed to backup sounds.\n\n" + ex;
                    return false;
                }
            }
            return true;
        }

        private bool unpackBDT(string name, string key, Progress progress, bool required)
        {
            if (stop)
                return true;

            string bhdPath = gameDir + "\\" + name + ".bhd";
            string bdtPath = gameDir + "\\" + name + ".bdt";
            if (!(File.Exists(bhdPath) && File.Exists(bdtPath)))
            {
                if (required)
                {
                    Error = "File not found:\n" + (File.Exists(bhdPath) ? bdtPath : bhdPath);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            Status = "Unpacking " + name + "...";

            Bhd5File bhd;
            try
            {
                using (MemoryStream bhdStream = CryptographyUtility.DecryptRsa(bhdPath, key))
                {
                    bhd = Bhd5File.Read(bhdStream, GameVersion.DarkSouls3);
                }
            }
            catch (Exception ex)
            {
                Error = $"Failed to open BHD:\n{bhdPath}\n\n{ex}";
                return false;
            }

            int fileCount = 0;
            foreach (Bhd5Bucket bucket in bhd.GetBuckets())
                fileCount += bucket.GetEntries().Count();
            progress.Value = 0;
            progress.Max = fileCount;

            try
            {
                using (Bdt5FileStream bdtStream = Bdt5FileStream.OpenFile(bdtPath, FileMode.Open, FileAccess.Read))
                {
                    foreach (Bhd5Bucket bucket in bhd.GetBuckets())
                    {
                        foreach (Bhd5BucketEntry entry in bucket.GetEntries())
                        {
                            if (stop)
                                return true;

                            if (entry.FileSize == 0)
                            {
                                MemoryStream header = bdtStream.Read(entry.FileOffset, 48);
                                if (entry.IsEncrypted)
                                {
                                    MemoryStream disposer = header;
                                    header = CryptographyUtility.DecryptAesEcb(header, entry.AesKey.Key);
                                    disposer.Dispose();
                                }

                                byte[] signatureBytes = new byte[4];
                                header.Read(signatureBytes, 0, 4);
                                string signature = ASCII.GetString(signatureBytes);
                                if (signature != DcxFile.DcxSignature)
                                {
                                    Error = "Zero-length entry is not DCX in BHD:\n" + bhdPath;
                                    return false;
                                }

                                header.Position = 0;
                                entry.FileSize = DcxFile.DcxSize + DcxFile.ReadCompressedSize(header);
                                header.Dispose();
                            }

                            MemoryStream data;
                            if (entry.IsEncrypted)
                            {
                                data = bdtStream.Read(entry.FileOffset, entry.PaddedFileSize);
                                CryptographyUtility.DecryptAesEcb(data, entry.AesKey.Key, entry.AesKey.Ranges);
                                data.Position = 0;
                                data.SetLength(entry.FileSize);
                            }
                            else
                            {
                                data = bdtStream.Read(entry.FileOffset, entry.FileSize);
                            }

                            string path;
                            if (ArchiveDictionary.GetPath(entry.FileNameHash, out path))
                            {
                                path = gameDir + path.Replace('/', '\\');
                            }
                            else
                            {
                                path = $"{gameDir}\\_unknown\\{name}_{entry.FileNameHash:D10}";
                            }

                            try
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(path));
                                File.WriteAllBytes(path, data.ToArray());
                            }
                            catch (Exception ex)
                            {
                                Error = $"Failed to write file:\n{path}\n\n{ex}";
                                return false;
                            }

                            data.Dispose();
                            progress.Value++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = $"Failed to unpack BDT:\n{bdtPath}\n\n{ex}";
                return false;
            }

            return true;
        }

        public class Progress
        {
            public int Max, Value;

            public Progress()
            {
                Max = -1;
                Value = -1;
            }
        }
    }
}
