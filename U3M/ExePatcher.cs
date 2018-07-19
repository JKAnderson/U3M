using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace U3M
{
    static class ExePatcher
    {
        private static readonly Encoding UTF16 = Encoding.Unicode;

        public static bool Patch(string path, out string error)
        {
            if (!File.Exists(path))
            {
                error = "Executable not found:\n" + path;
                return false;
            }

            if (!File.Exists(path + ".bak"))
            {
                try
                {
                    File.Copy(path, path + ".bak");
                }
                catch (Exception ex)
                {
                    error = $"Failed to backup file:\n{path}\n\n{ex}";
                    return false;
                }
            }

            byte[] bytes;
            try
            {
                bytes = File.ReadAllBytes(path);
            }
            catch (Exception ex)
            {
                error = $"Failed to read file:\n{path}\n\n{ex}";
                return false;
            }

            try
            {
                replace(bytes, "data1:", "debug:");
                replace(bytes, "data2:", "debug:");
                replace(bytes, "data3:", "debug:");
                replace(bytes, "data4:", "debug:");
                replace(bytes, "data5:", "debug:");
                replace(bytes, "game_dlc1:", "interroot:");
                replace(bytes, "game_dlc2:", "interroot:");
            }
            catch (Exception ex)
            {
                error = $"Failed to patch file:\n{path}\n\n{ex}";
                return false;
            }

            try
            {
                error = null;
                File.WriteAllBytes(path, bytes);
                return true;
            }
            catch (Exception ex)
            {
                error = $"Failed to write file:\n{path}\n\n{ex}";
                return false;
            }
        }

        private static void replace(byte[] bytes, string target, string replacement)
        {
            byte[] targetBytes = UTF16.GetBytes(target);
            byte[] replacementBytes = UTF16.GetBytes(replacement);
            if (targetBytes.Length != replacementBytes.Length)
                throw new ArgumentException($"Target length: {targetBytes.Length} | Replacement length: {replacementBytes.Length}");

            List<int> offsets = findBytes(bytes, targetBytes);
            foreach (int offset in offsets)
                Array.Copy(replacementBytes, 0, bytes, offset, replacementBytes.Length);
        }

        private static List<int> findBytes(byte[] bytes, byte[] find)
        {
            List<int> offsets = new List<int>();
            for (int i = 0; i < bytes.Length - find.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < find.Length; j++)
                {
                    if (find[j] != bytes[i + j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    offsets.Add(i);
            }
            return offsets;
        }
    }
}
