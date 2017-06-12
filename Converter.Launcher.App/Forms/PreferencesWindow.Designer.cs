namespace Converter.Launcher.App.Forms
{
    partial class PreferencesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            this.generalBox = new System.Windows.Forms.GroupBox();
            this.checkforupdatesbox = new System.Windows.Forms.CheckBox();
            this.checkforupdateslabel = new System.Windows.Forms.Label();
            this.loggingbox = new System.Windows.Forms.CheckBox();
            this.loggingLabel = new System.Windows.Forms.Label();
            this.UpdaterBox = new System.Windows.Forms.GroupBox();
            this.InstallFolderBtn = new System.Windows.Forms.Button();
            this.InstallfolderBox = new System.Windows.Forms.TextBox();
            this.InstallFolderLabel = new System.Windows.Forms.Label();
            this.downloadfolderbtn = new System.Windows.Forms.Button();
            this.downloadfolderbox = new System.Windows.Forms.TextBox();
            this.downloadfolderlabel = new System.Windows.Forms.Label();
            this.launcherSoundsBox = new System.Windows.Forms.CheckBox();
            this.launchersoundsLabel = new System.Windows.Forms.Label();
            this.generalBox.SuspendLayout();
            this.UpdaterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalBox
            // 
            this.generalBox.Controls.Add(this.launcherSoundsBox);
            this.generalBox.Controls.Add(this.launchersoundsLabel);
            this.generalBox.Controls.Add(this.checkforupdatesbox);
            this.generalBox.Controls.Add(this.checkforupdateslabel);
            this.generalBox.Controls.Add(this.loggingbox);
            this.generalBox.Controls.Add(this.loggingLabel);
            this.generalBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalBox.Location = new System.Drawing.Point(0, 0);
            this.generalBox.Name = "generalBox";
            this.generalBox.Size = new System.Drawing.Size(344, 74);
            this.generalBox.TabIndex = 2;
            this.generalBox.TabStop = false;
            this.generalBox.Text = "General";
            // 
            // checkforupdatesbox
            // 
            this.checkforupdatesbox.AutoSize = true;
            this.checkforupdatesbox.Location = new System.Drawing.Point(313, 34);
            this.checkforupdatesbox.Name = "checkforupdatesbox";
            this.checkforupdatesbox.Size = new System.Drawing.Size(15, 14);
            this.checkforupdatesbox.TabIndex = 5;
            this.checkforupdatesbox.UseVisualStyleBackColor = true;
            // 
            // checkforupdateslabel
            // 
            this.checkforupdateslabel.AutoSize = true;
            this.checkforupdateslabel.Location = new System.Drawing.Point(12, 34);
            this.checkforupdateslabel.Name = "checkforupdateslabel";
            this.checkforupdateslabel.Size = new System.Drawing.Size(144, 13);
            this.checkforupdateslabel.TabIndex = 4;
            this.checkforupdateslabel.Text = "Check for updates on startup";
            // 
            // loggingbox
            // 
            this.loggingbox.AutoSize = true;
            this.loggingbox.Location = new System.Drawing.Point(313, 22);
            this.loggingbox.Name = "loggingbox";
            this.loggingbox.Size = new System.Drawing.Size(15, 14);
            this.loggingbox.TabIndex = 1;
            this.loggingbox.UseVisualStyleBackColor = true;
            // 
            // loggingLabel
            // 
            this.loggingLabel.AutoSize = true;
            this.loggingLabel.Location = new System.Drawing.Point(12, 21);
            this.loggingLabel.Name = "loggingLabel";
            this.loggingLabel.Size = new System.Drawing.Size(77, 13);
            this.loggingLabel.TabIndex = 0;
            this.loggingLabel.Text = "Enable logging";
            // 
            // UpdaterBox
            // 
            this.UpdaterBox.Controls.Add(this.InstallFolderBtn);
            this.UpdaterBox.Controls.Add(this.InstallfolderBox);
            this.UpdaterBox.Controls.Add(this.InstallFolderLabel);
            this.UpdaterBox.Controls.Add(this.downloadfolderbtn);
            this.UpdaterBox.Controls.Add(this.downloadfolderbox);
            this.UpdaterBox.Controls.Add(this.downloadfolderlabel);
            this.UpdaterBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdaterBox.Location = new System.Drawing.Point(0, 74);
            this.UpdaterBox.Name = "UpdaterBox";
            this.UpdaterBox.Size = new System.Drawing.Size(344, 121);
            this.UpdaterBox.TabIndex = 3;
            this.UpdaterBox.TabStop = false;
            this.UpdaterBox.Text = "Updater";
            // 
            // InstallFolderBtn
            // 
            this.InstallFolderBtn.Location = new System.Drawing.Point(309, 72);
            this.InstallFolderBtn.Name = "InstallFolderBtn";
            this.InstallFolderBtn.Size = new System.Drawing.Size(25, 23);
            this.InstallFolderBtn.TabIndex = 11;
            this.InstallFolderBtn.Text = "...";
            this.InstallFolderBtn.UseVisualStyleBackColor = true;
            this.InstallFolderBtn.Click += new System.EventHandler(this.InstallFolderBtn_Click);
            // 
            // InstallfolderBox
            // 
            this.InstallfolderBox.Location = new System.Drawing.Point(27, 72);
            this.InstallfolderBox.Name = "InstallfolderBox";
            this.InstallfolderBox.ReadOnly = true;
            this.InstallfolderBox.Size = new System.Drawing.Size(276, 20);
            this.InstallfolderBox.TabIndex = 10;
            // 
            // InstallFolderLabel
            // 
            this.InstallFolderLabel.AutoSize = true;
            this.InstallFolderLabel.Location = new System.Drawing.Point(12, 56);
            this.InstallFolderLabel.Name = "InstallFolderLabel";
            this.InstallFolderLabel.Size = new System.Drawing.Size(63, 13);
            this.InstallFolderLabel.TabIndex = 9;
            this.InstallFolderLabel.Text = "Install folder";
            // 
            // downloadfolderbtn
            // 
            this.downloadfolderbtn.Location = new System.Drawing.Point(309, 32);
            this.downloadfolderbtn.Name = "downloadfolderbtn";
            this.downloadfolderbtn.Size = new System.Drawing.Size(25, 23);
            this.downloadfolderbtn.TabIndex = 8;
            this.downloadfolderbtn.Text = "...";
            this.downloadfolderbtn.UseVisualStyleBackColor = true;
            this.downloadfolderbtn.Click += new System.EventHandler(this.downloadfolderbtn_Click);
            // 
            // downloadfolderbox
            // 
            this.downloadfolderbox.Location = new System.Drawing.Point(27, 32);
            this.downloadfolderbox.Name = "downloadfolderbox";
            this.downloadfolderbox.ReadOnly = true;
            this.downloadfolderbox.Size = new System.Drawing.Size(276, 20);
            this.downloadfolderbox.TabIndex = 7;
            // 
            // downloadfolderlabel
            // 
            this.downloadfolderlabel.AutoSize = true;
            this.downloadfolderlabel.Location = new System.Drawing.Point(12, 16);
            this.downloadfolderlabel.Name = "downloadfolderlabel";
            this.downloadfolderlabel.Size = new System.Drawing.Size(123, 13);
            this.downloadfolderlabel.TabIndex = 6;
            this.downloadfolderlabel.Text = "Updater download folder";
            // 
            // launcherSoundsBox
            // 
            this.launcherSoundsBox.AutoSize = true;
            this.launcherSoundsBox.Location = new System.Drawing.Point(313, 47);
            this.launcherSoundsBox.Name = "launcherSoundsBox";
            this.launcherSoundsBox.Size = new System.Drawing.Size(15, 14);
            this.launcherSoundsBox.TabIndex = 7;
            this.launcherSoundsBox.UseVisualStyleBackColor = true;
            // 
            // launchersoundsLabel
            // 
            this.launchersoundsLabel.AutoSize = true;
            this.launchersoundsLabel.Location = new System.Drawing.Point(12, 48);
            this.launchersoundsLabel.Name = "launchersoundsLabel";
            this.launchersoundsLabel.Size = new System.Drawing.Size(121, 13);
            this.launchersoundsLabel.TabIndex = 6;
            this.launchersoundsLabel.Text = "Enable launcher sounds";
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 199);
            this.Controls.Add(this.UpdaterBox);
            this.Controls.Add(this.generalBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesWindow_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.generalBox.ResumeLayout(false);
            this.generalBox.PerformLayout();
            this.UpdaterBox.ResumeLayout(false);
            this.UpdaterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox generalBox;
        private System.Windows.Forms.CheckBox checkforupdatesbox;
        private System.Windows.Forms.Label checkforupdateslabel;
        private System.Windows.Forms.CheckBox loggingbox;
        private System.Windows.Forms.Label loggingLabel;
        private System.Windows.Forms.GroupBox UpdaterBox;
        private System.Windows.Forms.Button InstallFolderBtn;
        private System.Windows.Forms.TextBox InstallfolderBox;
        private System.Windows.Forms.Label InstallFolderLabel;
        private System.Windows.Forms.Button downloadfolderbtn;
        private System.Windows.Forms.TextBox downloadfolderbox;
        private System.Windows.Forms.Label downloadfolderlabel;
        private System.Windows.Forms.CheckBox launcherSoundsBox;
        private System.Windows.Forms.Label launchersoundsLabel;
    }
}