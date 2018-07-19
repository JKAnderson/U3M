using Semver;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace U3M
{
    public partial class FormMain : Form
    {
        private const string UPDATE_LINK = "https://www.nexusmods.com/darksouls3/mods/286?tab=files";
        private static Properties.Settings settings = Properties.Settings.Default;

        private bool abort;
        private ProgressManager pmData1, pmData2, pmData3, pmData4, pmData5, pmDLC1, pmDLC2;
        private ArchiveUnpacker unpacker;
        private Thread unpackThread;

        public FormMain()
        {
            InitializeComponent();
            abort = false;
            pmData1 = new ProgressManager(lblData1Progress, pbrData1);
            pmData2 = new ProgressManager(lblData2Progress, pbrData2);
            pmData3 = new ProgressManager(lblData3Progress, pbrData3);
            pmData4 = new ProgressManager(lblData4Progress, pbrData4);
            pmData5 = new ProgressManager(lblData5Progress, pbrData5);
            pmDLC1 = new ProgressManager(lblDLC1Progress, pbrDLC1);
            pmDLC2 = new ProgressManager(lblDLC2Progress, pbrDLC2);
            unpacker = null;
            unpackThread = null;
        }

        private static void showError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void enableControls(bool enable)
        {
            txtGameDir.Enabled = enable;
            btnBrowse.Enabled = enable;
            btnAbort.Enabled = !enable;
            btnRestore.Enabled = enable;
            btnPatch.Enabled = enable;
            btnUnpack.Enabled = enable;

            cbxData1.Enabled = enable;
            cbxData2.Enabled = enable;
            cbxData3.Enabled = enable;
            cbxData4.Enabled = enable;
            cbxData5.Enabled = enable;
            cbxDLC1.Enabled = enable;
            cbxDLC2.Enabled = enable;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = "U3M Beta " + Application.ProductVersion;
            enableControls(true);

            Location = settings.WindowLocation;
            if (settings.WindowSize.Width >= MinimumSize.Width && settings.WindowSize.Height >= MinimumSize.Height)
                Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            txtGameDir.Text = settings.GameDir;
            cbxData1.Checked = settings.Data1Checked;
            cbxData2.Checked = settings.Data2Checked;
            cbxData3.Checked = settings.Data3Checked;
            cbxData4.Checked = settings.Data4Checked;
            cbxData5.Checked = settings.Data5Checked;
            cbxDLC1.Checked = settings.DLC1Checked;
            cbxDLC2.Checked = settings.DLC2Checked;

            Octokit.GitHubClient gitHubClient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("U3M"));
            try
            {
                Octokit.Release release = await gitHubClient.Repository.Release.GetLatest("JKAnderson", "U3M");
                if (SemVersion.Parse(release.TagName) > Application.ProductVersion)
                {
                    lblUpdate.Visible = false;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = UPDATE_LINK;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is Octokit.ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Update status unknown";
            }
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unpacker != null)
            {
                unpacker.Stop();
                abort = true;
                e.Cancel = true;
            }
            else
            {
                settings.WindowMaximized = WindowState == FormWindowState.Maximized;
                if (WindowState == FormWindowState.Normal)
                {
                    settings.WindowLocation = Location;
                    settings.WindowSize = Size;
                }
                else
                {
                    settings.WindowLocation = RestoreBounds.Location;
                    settings.WindowSize = RestoreBounds.Size;
                }

                settings.GameDir = txtGameDir.Text;
                settings.Data1Checked = cbxData1.Checked;
                settings.Data2Checked = cbxData2.Checked;
                settings.Data3Checked = cbxData3.Checked;
                settings.Data4Checked = cbxData4.Checked;
                settings.Data5Checked = cbxData5.Checked;
                settings.DLC1Checked = cbxDLC1.Checked;
                settings.DLC2Checked = cbxDLC2.Checked;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdExe.InitialDirectory = txtGameDir.Text;
            if (ofdExe.ShowDialog() == DialogResult.OK)
                txtGameDir.Text = Path.GetDirectoryName(ofdExe.FileName);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtGameDir.Text))
                Process.Start(txtGameDir.Text);
            else
                SystemSounds.Hand.Play();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            unpacker.Stop();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Restoring the game will delete most of the folders in your game directory.\n"
                + "If you have any mods you don't want to lose, please cancel now.",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (choice == DialogResult.OK)
            {
                string exePath = txtGameDir.Text + "\\DarkSoulsIII.exe";
                if (File.Exists(exePath + ".bak"))
                {
                    try
                    {
                        File.Delete(exePath);
                        File.Move(exePath + ".bak", exePath);
                    }
                    catch (Exception ex)
                    {
                        showError("Failed to restore executable.\n\n" + ex);
                        return;
                    }
                }

                string soundDir = txtGameDir.Text + "\\sound";
                if (Directory.Exists(soundDir + "-bak"))
                {
                    try
                    {
                        if (Directory.Exists(soundDir))
                            Directory.Delete(soundDir, true);
                        Directory.Move(soundDir + "-bak", soundDir);
                    }
                    catch (Exception ex)
                    {
                        showError("Failed to restore sounds.\n\n" + ex);
                        return;
                    }
                }

                try
                {
                    deleteDir("_unknown");
                    deleteDir("action");
                    deleteDir("chr");
                    deleteDir("event");
                    deleteDir("facegen");
                    deleteDir("font");
                    deleteDir("map");
                    deleteDir("menu");
                    deleteDir("msg");
                    deleteDir("mtd");
                    deleteDir("obj");
                    deleteDir("other");
                    deleteDir("param");
                    deleteDir("parts");
                    deleteDir("remo");
                    deleteDir("script");
                    deleteDir("sfx");
                    deleteDir("shader");
                }
                catch (Exception ex)
                {
                    showError("Failed to delete directory.\n\n" + ex);
                    return;
                }

                txtStatus.Text = "Game restored!";
                SystemSounds.Asterisk.Play();
            }
        }

        private void deleteDir(string name)
        {
            if (Directory.Exists(txtGameDir.Text + "\\" + name))
                Directory.Delete(txtGameDir.Text + "\\" + name, true);
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Patching executable...";
            if (!ExePatcher.Patch(txtGameDir.Text + "\\DarkSoulsIII.exe", out string error))
            {
                showError(error);
            }
            else
            {
                txtStatus.Text = "Executable patched!";
                SystemSounds.Asterisk.Play();
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            enableControls(false);
            unpacker = new ArchiveUnpacker(txtGameDir.Text,
                cbxData1.Checked, cbxData2.Checked, cbxData3.Checked, cbxData4.Checked, cbxData5.Checked, cbxDLC1.Checked, cbxDLC2.Checked);
            unpackThread = unpacker.Start();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (unpacker != null)
            {
                if (unpackThread.ThreadState == System.Threading.ThreadState.Running)
                {
                    checkProgress();
                }
                else
                {
                    checkProgress();
                    bool success = unpacker.Success;
                    string error = unpacker.Error;
                    unpacker = null;
                    unpackThread = null;

                    if (success)
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    else if (!abort)
                    {
                        showError(error);
                    }

                    pmData1.Reset();
                    pmData2.Reset();
                    pmData3.Reset();
                    pmData4.Reset();
                    pmData5.Reset();
                    pmDLC1.Reset();
                    pmDLC2.Reset();
                    enableControls(true);

                    if (abort)
                        Close();
                }
            }
        }

        private void checkProgress()
        {
            txtStatus.Text = unpacker.Status;
            pmData1.Update(unpacker.Data1Progress);
            pmData2.Update(unpacker.Data2Progress);
            pmData3.Update(unpacker.Data3Progress);
            pmData4.Update(unpacker.Data4Progress);
            pmData5.Update(unpacker.Data5Progress);
            pmDLC1.Update(unpacker.DLC1Progress);
            pmDLC2.Update(unpacker.DLC2Progress);
        }

        private class ProgressManager
        {
            private Label lbl;
            private ProgressBar pbr;

            public ProgressManager(Label label, ProgressBar progressBar)
            {
                lbl = label;
                pbr = progressBar;
                Reset();
            }

            public void Reset()
            {
                lbl.Visible = false;
                pbr.Value = 0;
                pbr.Maximum = 0;
            }

            public void Update(ArchiveUnpacker.Progress progress)
            {
                if (progress.Max != -1)
                {
                    if (pbr.Maximum == 0)
                    {
                        lbl.Visible = true;
                        pbr.Maximum = progress.Max;
                    }

                    lbl.Text = $"{progress.Value}/{progress.Max}";
                    pbr.Value = progress.Value;
                }
            }
        }
    }
}
