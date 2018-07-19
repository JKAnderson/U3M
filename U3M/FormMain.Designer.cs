namespace U3M
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblBreak;
            System.Windows.Forms.Label lblData1;
            System.Windows.Forms.Label lblData2;
            System.Windows.Forms.Label lblData3;
            System.Windows.Forms.Label lblData4;
            System.Windows.Forms.Label lblData5;
            System.Windows.Forms.Label lblDLC1;
            System.Windows.Forms.Label lblDLC2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.pbrData1 = new System.Windows.Forms.ProgressBar();
            this.pbrData2 = new System.Windows.Forms.ProgressBar();
            this.pbrData3 = new System.Windows.Forms.ProgressBar();
            this.pbrData4 = new System.Windows.Forms.ProgressBar();
            this.pbrData5 = new System.Windows.Forms.ProgressBar();
            this.pbrDLC1 = new System.Windows.Forms.ProgressBar();
            this.pbrDLC2 = new System.Windows.Forms.ProgressBar();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.ofdExe = new System.Windows.Forms.OpenFileDialog();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.lblData5Progress = new System.Windows.Forms.Label();
            this.lblDLC1Progress = new System.Windows.Forms.Label();
            this.lblData4Progress = new System.Windows.Forms.Label();
            this.lblData3Progress = new System.Windows.Forms.Label();
            this.lblData2Progress = new System.Windows.Forms.Label();
            this.lblData1Progress = new System.Windows.Forms.Label();
            this.lblDLC2Progress = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxData1 = new System.Windows.Forms.CheckBox();
            this.cbxData2 = new System.Windows.Forms.CheckBox();
            this.cbxData3 = new System.Windows.Forms.CheckBox();
            this.cbxData4 = new System.Windows.Forms.CheckBox();
            this.cbxData5 = new System.Windows.Forms.CheckBox();
            this.cbxDLC1 = new System.Windows.Forms.CheckBox();
            this.cbxDLC2 = new System.Windows.Forms.CheckBox();
            lblGameDir = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblBreak = new System.Windows.Forms.Label();
            lblData1 = new System.Windows.Forms.Label();
            lblData2 = new System.Windows.Forms.Label();
            lblData3 = new System.Windows.Forms.Label();
            lblData4 = new System.Windows.Forms.Label();
            lblData5 = new System.Windows.Forms.Label();
            lblDLC1 = new System.Windows.Forms.Label();
            lblDLC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(12, 9);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(80, 13);
            lblGameDir.TabIndex = 6;
            lblGameDir.Text = "Game Directory";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(12, 94);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(37, 13);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // lblBreak
            // 
            lblBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblBreak.Location = new System.Drawing.Point(-13, 85);
            lblBreak.Name = "lblBreak";
            lblBreak.Size = new System.Drawing.Size(665, 2);
            lblBreak.TabIndex = 22;
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(12, 25);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(455, 20);
            this.txtGameDir.TabIndex = 0;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS III\\Game";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(473, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnBrowse, "Browse for your DS3 executable");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplore.Location = new System.Drawing.Point(554, 23);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 2;
            this.btnExplore.Text = "Explore";
            this.toolTip1.SetToolTip(this.btnExplore, "Open the game directory in Explorer");
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(554, 52);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.toolTip1.SetToolTip(this.btnAbort, "Cancel the current operation");
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(473, 52);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.toolTip1.SetToolTip(this.btnRestore, "Restore unpatched executable and delete unpacked files");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(311, 52);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 3;
            this.btnUnpack.Text = "Unpack";
            this.toolTip1.SetToolTip(this.btnUnpack, "Unpack the archives selected below");
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.Location = new System.Drawing.Point(392, 52);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(75, 23);
            this.btnPatch.TabIndex = 4;
            this.btnPatch.Text = "Patch";
            this.toolTip1.SetToolTip(this.btnPatch, "Patch the executable to load unpacked files");
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // pbrData1
            // 
            this.pbrData1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrData1.Location = new System.Drawing.Point(12, 156);
            this.pbrData1.Maximum = 0;
            this.pbrData1.Name = "pbrData1";
            this.pbrData1.Size = new System.Drawing.Size(617, 23);
            this.pbrData1.TabIndex = 8;
            // 
            // pbrData2
            // 
            this.pbrData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrData2.Location = new System.Drawing.Point(12, 205);
            this.pbrData2.Maximum = 0;
            this.pbrData2.Name = "pbrData2";
            this.pbrData2.Size = new System.Drawing.Size(617, 23);
            this.pbrData2.TabIndex = 10;
            // 
            // pbrData3
            // 
            this.pbrData3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrData3.Location = new System.Drawing.Point(12, 254);
            this.pbrData3.Maximum = 0;
            this.pbrData3.Name = "pbrData3";
            this.pbrData3.Size = new System.Drawing.Size(617, 23);
            this.pbrData3.TabIndex = 12;
            // 
            // pbrData4
            // 
            this.pbrData4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrData4.Location = new System.Drawing.Point(12, 303);
            this.pbrData4.Maximum = 0;
            this.pbrData4.Name = "pbrData4";
            this.pbrData4.Size = new System.Drawing.Size(617, 23);
            this.pbrData4.TabIndex = 14;
            // 
            // pbrData5
            // 
            this.pbrData5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrData5.Location = new System.Drawing.Point(12, 352);
            this.pbrData5.Maximum = 0;
            this.pbrData5.Name = "pbrData5";
            this.pbrData5.Size = new System.Drawing.Size(617, 23);
            this.pbrData5.TabIndex = 16;
            // 
            // pbrDLC1
            // 
            this.pbrDLC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrDLC1.Location = new System.Drawing.Point(12, 401);
            this.pbrDLC1.Maximum = 0;
            this.pbrDLC1.Name = "pbrDLC1";
            this.pbrDLC1.Size = new System.Drawing.Size(617, 23);
            this.pbrDLC1.TabIndex = 18;
            // 
            // pbrDLC2
            // 
            this.pbrDLC2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrDLC2.Location = new System.Drawing.Point(12, 450);
            this.pbrDLC2.Maximum = 0;
            this.pbrDLC2.Name = "pbrDLC2";
            this.pbrDLC2.Size = new System.Drawing.Size(617, 23);
            this.pbrDLC2.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(12, 110);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(617, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // ofdExe
            // 
            this.ofdExe.FileName = "DarkSoulsIII.exe";
            this.ofdExe.Filter = "Dark Souls 3 Executable|*.exe";
            this.ofdExe.Title = "Select Dark Souls 3 executable...";
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // lblData5Progress
            // 
            this.lblData5Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData5Progress.Location = new System.Drawing.Point(473, 332);
            this.lblData5Progress.Name = "lblData5Progress";
            this.lblData5Progress.Size = new System.Drawing.Size(156, 13);
            this.lblData5Progress.TabIndex = 23;
            this.lblData5Progress.Text = "0000/0000";
            this.lblData5Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData5Progress.Visible = false;
            // 
            // lblDLC1Progress
            // 
            this.lblDLC1Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDLC1Progress.Location = new System.Drawing.Point(473, 381);
            this.lblDLC1Progress.Name = "lblDLC1Progress";
            this.lblDLC1Progress.Size = new System.Drawing.Size(156, 13);
            this.lblDLC1Progress.TabIndex = 24;
            this.lblDLC1Progress.Text = "0000/0000";
            this.lblDLC1Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDLC1Progress.Visible = false;
            // 
            // lblData4Progress
            // 
            this.lblData4Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData4Progress.Location = new System.Drawing.Point(473, 283);
            this.lblData4Progress.Name = "lblData4Progress";
            this.lblData4Progress.Size = new System.Drawing.Size(156, 13);
            this.lblData4Progress.TabIndex = 25;
            this.lblData4Progress.Text = "0000/0000";
            this.lblData4Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData4Progress.Visible = false;
            // 
            // lblData3Progress
            // 
            this.lblData3Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData3Progress.Location = new System.Drawing.Point(473, 234);
            this.lblData3Progress.Name = "lblData3Progress";
            this.lblData3Progress.Size = new System.Drawing.Size(156, 13);
            this.lblData3Progress.TabIndex = 26;
            this.lblData3Progress.Text = "0000/0000";
            this.lblData3Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData3Progress.Visible = false;
            // 
            // lblData2Progress
            // 
            this.lblData2Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData2Progress.Location = new System.Drawing.Point(473, 185);
            this.lblData2Progress.Name = "lblData2Progress";
            this.lblData2Progress.Size = new System.Drawing.Size(156, 13);
            this.lblData2Progress.TabIndex = 27;
            this.lblData2Progress.Text = "0000/0000";
            this.lblData2Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData2Progress.Visible = false;
            // 
            // lblData1Progress
            // 
            this.lblData1Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData1Progress.Location = new System.Drawing.Point(473, 136);
            this.lblData1Progress.Name = "lblData1Progress";
            this.lblData1Progress.Size = new System.Drawing.Size(156, 13);
            this.lblData1Progress.TabIndex = 28;
            this.lblData1Progress.Text = "0000/0000";
            this.lblData1Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData1Progress.Visible = false;
            // 
            // lblDLC2Progress
            // 
            this.lblDLC2Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDLC2Progress.Location = new System.Drawing.Point(473, 430);
            this.lblDLC2Progress.Name = "lblDLC2Progress";
            this.lblDLC2Progress.Size = new System.Drawing.Size(156, 13);
            this.lblDLC2Progress.TabIndex = 29;
            this.lblDLC2Progress.Text = "0000/0000";
            this.lblDLC2Progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDLC2Progress.Visible = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.Location = new System.Drawing.Point(176, 482);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(453, 13);
            this.lblUpdate.TabIndex = 30;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbUpdate.Location = new System.Drawing.Point(179, 482);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(450, 13);
            this.llbUpdate.TabIndex = 31;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // cbxData1
            // 
            this.cbxData1.AutoSize = true;
            this.cbxData1.Checked = true;
            this.cbxData1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData1.Location = new System.Drawing.Point(15, 136);
            this.cbxData1.Name = "cbxData1";
            this.cbxData1.Size = new System.Drawing.Size(15, 14);
            this.cbxData1.TabIndex = 32;
            this.toolTip1.SetToolTip(this.cbxData1, "Uncheck to skip unpacking Data1");
            this.cbxData1.UseVisualStyleBackColor = true;
            // 
            // cbxData2
            // 
            this.cbxData2.AutoSize = true;
            this.cbxData2.Checked = true;
            this.cbxData2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData2.Location = new System.Drawing.Point(15, 185);
            this.cbxData2.Name = "cbxData2";
            this.cbxData2.Size = new System.Drawing.Size(15, 14);
            this.cbxData2.TabIndex = 33;
            this.toolTip1.SetToolTip(this.cbxData2, "Uncheck to skip unpacking Data2");
            this.cbxData2.UseVisualStyleBackColor = true;
            // 
            // cbxData3
            // 
            this.cbxData3.AutoSize = true;
            this.cbxData3.Checked = true;
            this.cbxData3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData3.Location = new System.Drawing.Point(15, 234);
            this.cbxData3.Name = "cbxData3";
            this.cbxData3.Size = new System.Drawing.Size(15, 14);
            this.cbxData3.TabIndex = 34;
            this.toolTip1.SetToolTip(this.cbxData3, "Uncheck to skip unpacking Data3");
            this.cbxData3.UseVisualStyleBackColor = true;
            // 
            // cbxData4
            // 
            this.cbxData4.AutoSize = true;
            this.cbxData4.Checked = true;
            this.cbxData4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData4.Location = new System.Drawing.Point(15, 283);
            this.cbxData4.Name = "cbxData4";
            this.cbxData4.Size = new System.Drawing.Size(15, 14);
            this.cbxData4.TabIndex = 35;
            this.toolTip1.SetToolTip(this.cbxData4, "Uncheck to skip unpacking Data4");
            this.cbxData4.UseVisualStyleBackColor = true;
            // 
            // cbxData5
            // 
            this.cbxData5.AutoSize = true;
            this.cbxData5.Checked = true;
            this.cbxData5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData5.Location = new System.Drawing.Point(15, 332);
            this.cbxData5.Name = "cbxData5";
            this.cbxData5.Size = new System.Drawing.Size(15, 14);
            this.cbxData5.TabIndex = 36;
            this.toolTip1.SetToolTip(this.cbxData5, "Uncheck to skip unpacking Data5");
            this.cbxData5.UseVisualStyleBackColor = true;
            // 
            // cbxDLC1
            // 
            this.cbxDLC1.AutoSize = true;
            this.cbxDLC1.Checked = true;
            this.cbxDLC1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDLC1.Location = new System.Drawing.Point(15, 381);
            this.cbxDLC1.Name = "cbxDLC1";
            this.cbxDLC1.Size = new System.Drawing.Size(15, 14);
            this.cbxDLC1.TabIndex = 37;
            this.toolTip1.SetToolTip(this.cbxDLC1, "Uncheck to skip unpacking DLC1");
            this.cbxDLC1.UseVisualStyleBackColor = true;
            // 
            // cbxDLC2
            // 
            this.cbxDLC2.AutoSize = true;
            this.cbxDLC2.Checked = true;
            this.cbxDLC2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDLC2.Location = new System.Drawing.Point(15, 430);
            this.cbxDLC2.Name = "cbxDLC2";
            this.cbxDLC2.Size = new System.Drawing.Size(15, 14);
            this.cbxDLC2.TabIndex = 38;
            this.toolTip1.SetToolTip(this.cbxDLC2, "Uncheck to skip unpacking DLC2");
            this.cbxDLC2.UseVisualStyleBackColor = true;
            // 
            // lblData1
            // 
            lblData1.AutoSize = true;
            lblData1.Location = new System.Drawing.Point(36, 136);
            lblData1.Name = "lblData1";
            lblData1.Size = new System.Drawing.Size(36, 13);
            lblData1.TabIndex = 39;
            lblData1.Text = "Data1";
            // 
            // lblData2
            // 
            lblData2.AutoSize = true;
            lblData2.Location = new System.Drawing.Point(36, 185);
            lblData2.Name = "lblData2";
            lblData2.Size = new System.Drawing.Size(36, 13);
            lblData2.TabIndex = 40;
            lblData2.Text = "Data2";
            // 
            // lblData3
            // 
            lblData3.AutoSize = true;
            lblData3.Location = new System.Drawing.Point(36, 234);
            lblData3.Name = "lblData3";
            lblData3.Size = new System.Drawing.Size(36, 13);
            lblData3.TabIndex = 41;
            lblData3.Text = "Data3";
            // 
            // lblData4
            // 
            lblData4.AutoSize = true;
            lblData4.Location = new System.Drawing.Point(36, 283);
            lblData4.Name = "lblData4";
            lblData4.Size = new System.Drawing.Size(36, 13);
            lblData4.TabIndex = 42;
            lblData4.Text = "Data4";
            // 
            // lblData5
            // 
            lblData5.AutoSize = true;
            lblData5.Location = new System.Drawing.Point(36, 332);
            lblData5.Name = "lblData5";
            lblData5.Size = new System.Drawing.Size(36, 13);
            lblData5.TabIndex = 43;
            lblData5.Text = "Data5";
            // 
            // lblDLC1
            // 
            lblDLC1.AutoSize = true;
            lblDLC1.Location = new System.Drawing.Point(36, 381);
            lblDLC1.Name = "lblDLC1";
            lblDLC1.Size = new System.Drawing.Size(34, 13);
            lblDLC1.TabIndex = 44;
            lblDLC1.Text = "DLC1";
            // 
            // lblDLC2
            // 
            lblDLC2.AutoSize = true;
            lblDLC2.Location = new System.Drawing.Point(36, 430);
            lblDLC2.Name = "lblDLC2";
            lblDLC2.Size = new System.Drawing.Size(34, 13);
            lblDLC2.TabIndex = 45;
            lblDLC2.Text = "DLC2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 511);
            this.Controls.Add(lblDLC2);
            this.Controls.Add(lblDLC1);
            this.Controls.Add(lblData5);
            this.Controls.Add(lblData4);
            this.Controls.Add(lblData3);
            this.Controls.Add(lblData2);
            this.Controls.Add(lblData1);
            this.Controls.Add(this.cbxDLC2);
            this.Controls.Add(this.cbxDLC1);
            this.Controls.Add(this.cbxData5);
            this.Controls.Add(this.cbxData4);
            this.Controls.Add(this.cbxData3);
            this.Controls.Add(this.cbxData2);
            this.Controls.Add(this.cbxData1);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(lblBreak);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(lblStatus);
            this.Controls.Add(this.pbrDLC2);
            this.Controls.Add(this.pbrDLC1);
            this.Controls.Add(this.pbrData5);
            this.Controls.Add(this.pbrData4);
            this.Controls.Add(this.pbrData3);
            this.Controls.Add(this.pbrData2);
            this.Controls.Add(this.pbrData1);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Controls.Add(this.lblDLC2Progress);
            this.Controls.Add(this.lblData1Progress);
            this.Controls.Add(this.lblData2Progress);
            this.Controls.Add(this.lblData3Progress);
            this.Controls.Add(this.lblData4Progress);
            this.Controls.Add(this.lblDLC1Progress);
            this.Controls.Add(this.lblData5Progress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 549);
            this.MinimumSize = new System.Drawing.Size(357, 549);
            this.Name = "FormMain";
            this.Text = "U3M <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.ProgressBar pbrData1;
        private System.Windows.Forms.ProgressBar pbrData2;
        private System.Windows.Forms.ProgressBar pbrData3;
        private System.Windows.Forms.ProgressBar pbrData4;
        private System.Windows.Forms.ProgressBar pbrData5;
        private System.Windows.Forms.ProgressBar pbrDLC1;
        private System.Windows.Forms.ProgressBar pbrDLC2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.OpenFileDialog ofdExe;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Label lblData5Progress;
        private System.Windows.Forms.Label lblDLC1Progress;
        private System.Windows.Forms.Label lblData4Progress;
        private System.Windows.Forms.Label lblData3Progress;
        private System.Windows.Forms.Label lblData2Progress;
        private System.Windows.Forms.Label lblData1Progress;
        private System.Windows.Forms.Label lblDLC2Progress;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxData1;
        private System.Windows.Forms.CheckBox cbxData2;
        private System.Windows.Forms.CheckBox cbxData3;
        private System.Windows.Forms.CheckBox cbxData4;
        private System.Windows.Forms.CheckBox cbxData5;
        private System.Windows.Forms.CheckBox cbxDLC1;
        private System.Windows.Forms.CheckBox cbxDLC2;
    }
}

