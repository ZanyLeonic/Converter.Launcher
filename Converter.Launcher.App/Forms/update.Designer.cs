namespace POSUpdater.Forms
{
    partial class update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.localVersionBox = new System.Windows.Forms.TextBox();
            this.installedVersionLabel = new System.Windows.Forms.Label();
            this.gitVersionBox = new System.Windows.Forms.TextBox();
            this.githubVersion = new System.Windows.Forms.Label();
            this.releaseNotes = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshReleaseInfoBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.installPath = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.browseDir = new System.Windows.Forms.Button();
            this.folderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateBtn.Location = new System.Drawing.Point(0, 388);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(399, 43);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Check for updates";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // localVersionBox
            // 
            this.localVersionBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.localVersionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localVersionBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localVersionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.localVersionBox.Location = new System.Drawing.Point(12, 30);
            this.localVersionBox.Name = "localVersionBox";
            this.localVersionBox.ReadOnly = true;
            this.localVersionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.localVersionBox.Size = new System.Drawing.Size(100, 20);
            this.localVersionBox.TabIndex = 1;
            // 
            // installedVersionLabel
            // 
            this.installedVersionLabel.AutoSize = true;
            this.installedVersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installedVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.installedVersionLabel.Location = new System.Drawing.Point(9, 10);
            this.installedVersionLabel.Name = "installedVersionLabel";
            this.installedVersionLabel.Size = new System.Drawing.Size(103, 15);
            this.installedVersionLabel.TabIndex = 2;
            this.installedVersionLabel.Text = "Installed version:";
            // 
            // gitVersionBox
            // 
            this.gitVersionBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gitVersionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gitVersionBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitVersionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gitVersionBox.Location = new System.Drawing.Point(118, 30);
            this.gitVersionBox.Name = "gitVersionBox";
            this.gitVersionBox.ReadOnly = true;
            this.gitVersionBox.Size = new System.Drawing.Size(102, 20);
            this.gitVersionBox.TabIndex = 4;
            // 
            // githubVersion
            // 
            this.githubVersion.AutoSize = true;
            this.githubVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.githubVersion.Location = new System.Drawing.Point(118, 10);
            this.githubVersion.Name = "githubVersion";
            this.githubVersion.Size = new System.Drawing.Size(91, 15);
            this.githubVersion.TabIndex = 5;
            this.githubVersion.Text = "Github version:";
            // 
            // releaseNotes
            // 
            this.releaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseNotes.Location = new System.Drawing.Point(0, 89);
            this.releaseNotes.MinimumSize = new System.Drawing.Size(20, 20);
            this.releaseNotes.Name = "releaseNotes";
            this.releaseNotes.Size = new System.Drawing.Size(399, 299);
            this.releaseNotes.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browseDir);
            this.panel1.Controls.Add(this.refreshReleaseInfoBtn);
            this.panel1.Controls.Add(this.localVersionBox);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.installPath);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Controls.Add(this.gitVersionBox);
            this.panel1.Controls.Add(this.githubVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 89);
            this.panel1.TabIndex = 7;
            // 
            // refreshReleaseInfoBtn
            // 
            this.refreshReleaseInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshReleaseInfoBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.refreshReleaseInfoBtn.Location = new System.Drawing.Point(226, 10);
            this.refreshReleaseInfoBtn.Name = "refreshReleaseInfoBtn";
            this.refreshReleaseInfoBtn.Size = new System.Drawing.Size(94, 41);
            this.refreshReleaseInfoBtn.TabIndex = 11;
            this.refreshReleaseInfoBtn.Text = "Refresh news";
            this.refreshReleaseInfoBtn.UseVisualStyleBackColor = true;
            this.refreshReleaseInfoBtn.Click += new System.EventHandler(this.refreshReleaseInfoBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(326, 10);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(61, 40);
            this.aboutBtn.TabIndex = 10;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // installPath
            // 
            this.installPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.installPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.installPath.Location = new System.Drawing.Point(79, 62);
            this.installPath.Name = "installPath";
            this.installPath.ReadOnly = true;
            this.installPath.Size = new System.Drawing.Size(273, 20);
            this.installPath.TabIndex = 9;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pathLabel.Location = new System.Drawing.Point(9, 64);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(70, 14);
            this.pathLabel.TabIndex = 8;
            this.pathLabel.Text = "Install path:";
            // 
            // browseDir
            // 
            this.browseDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseDir.Location = new System.Drawing.Point(358, 60);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(29, 23);
            this.browseDir.TabIndex = 12;
            this.browseDir.Text = "...";
            this.browseDir.UseVisualStyleBackColor = true;
            this.browseDir.Click += new System.EventHandler(this.browseDir_Click);
            // 
            // folderPicker
            // 
            this.folderPicker.Description = "Select the projectonimous game folder...";
            this.folderPicker.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderPicker.ShowNewFolderButton = false;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 431);
            this.Controls.Add(this.releaseNotes);
            this.Controls.Add(this.installedVersionLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox localVersionBox;
        private System.Windows.Forms.Label installedVersionLabel;
        private System.Windows.Forms.TextBox gitVersionBox;
        private System.Windows.Forms.Label githubVersion;
        private System.Windows.Forms.WebBrowser releaseNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox installPath;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button refreshReleaseInfoBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button browseDir;
        private System.Windows.Forms.FolderBrowserDialog folderPicker;
    }
}

