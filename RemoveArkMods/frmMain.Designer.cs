namespace RemoveArkMods
{
    sealed partial class frmMain
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
            this.btnDeleteMod = new System.Windows.Forms.Button();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.fbdArkInstallDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnArkInstallDir = new System.Windows.Forms.Button();
            this.lblArkInstallDir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModSteamInfo = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lstModDir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDeleteMod
            // 
            this.btnDeleteMod.Enabled = false;
            this.btnDeleteMod.Location = new System.Drawing.Point(217, 92);
            this.btnDeleteMod.Name = "btnDeleteMod";
            this.btnDeleteMod.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteMod.TabIndex = 0;
            this.btnDeleteMod.Text = "Delete mod";
            this.btnDeleteMod.UseVisualStyleBackColor = true;
            this.btnDeleteMod.Click += new System.EventHandler(this.btnDeleteMod_Click);
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(33, 93);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(178, 20);
            this.txtModId.TabIndex = 2;
            this.txtModId.TextChanged += new System.EventHandler(this.txtModId_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(30, 192);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(62, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Information:";
            // 
            // fbdArkInstallDir
            // 
            this.fbdArkInstallDir.Description = "Find the ARK folder, under steam directory";
            this.fbdArkInstallDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnArkInstallDir
            // 
            this.btnArkInstallDir.Location = new System.Drawing.Point(32, 44);
            this.btnArkInstallDir.Name = "btnArkInstallDir";
            this.btnArkInstallDir.Size = new System.Drawing.Size(75, 23);
            this.btnArkInstallDir.TabIndex = 3;
            this.btnArkInstallDir.Text = "Browse...";
            this.btnArkInstallDir.UseVisualStyleBackColor = true;
            this.btnArkInstallDir.Click += new System.EventHandler(this.btnArkInstallDir_Click);
            // 
            // lblArkInstallDir
            // 
            this.lblArkInstallDir.AutoSize = true;
            this.lblArkInstallDir.Location = new System.Drawing.Point(113, 49);
            this.lblArkInstallDir.Name = "lblArkInstallDir";
            this.lblArkInstallDir.Size = new System.Drawing.Size(168, 13);
            this.lblArkInstallDir.TabIndex = 1;
            this.lblArkInstallDir.Text = "Browse to set ARK install directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ModId:";
            // 
            // lblModSteamInfo
            // 
            this.lblModSteamInfo.AutoSize = true;
            this.lblModSteamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModSteamInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblModSteamInfo.Location = new System.Drawing.Point(30, 146);
            this.lblModSteamInfo.Name = "lblModSteamInfo";
            this.lblModSteamInfo.Size = new System.Drawing.Size(98, 13);
            this.lblModSteamInfo.TabIndex = 4;
            this.lblModSteamInfo.Text = "Steam mod info:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.Red;
            this.lblObs.Location = new System.Drawing.Point(30, 13);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(360, 13);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "You should unsubscribe the mod in steam before you delete it!";
            // 
            // lstModDir
            // 
            this.lstModDir.FormattingEnabled = true;
            this.lstModDir.Location = new System.Drawing.Point(448, 12);
            this.lstModDir.Name = "lstModDir";
            this.lstModDir.Size = new System.Drawing.Size(187, 160);
            this.lstModDir.TabIndex = 6;
            this.lstModDir.SelectedIndexChanged += new System.EventHandler(this.lstModDir_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 317);
            this.Controls.Add(this.lstModDir);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblModSteamInfo);
            this.Controls.Add(this.btnArkInstallDir);
            this.Controls.Add(this.txtModId);
            this.Controls.Add(this.lblArkInstallDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDeleteMod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Remove ARK mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMod;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FolderBrowserDialog fbdArkInstallDir;
        private System.Windows.Forms.Button btnArkInstallDir;
        private System.Windows.Forms.Label lblArkInstallDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModSteamInfo;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.ListBox lstModDir;
    }
}

