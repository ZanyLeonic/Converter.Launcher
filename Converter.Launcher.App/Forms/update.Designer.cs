using System.Windows.Forms;

namespace Converter.Launcher.App.Forms
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.loadingAnimation = new System.Windows.Forms.Timer(this.components);
            this.helpToolTip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.versionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherBackground = new System.Windows.Forms.Panel();
            this.checkForUpdatesBtn = new System.Windows.Forms.Button();
            this.appLabel = new System.Windows.Forms.Label();
            this.launcherSidebar = new System.Windows.Forms.Panel();
            this.quitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.launchBtn = new System.Windows.Forms.Button();
            this.loaderIndicator = new System.Windows.Forms.PictureBox();
            this.browserLoadingOverlay = new System.Windows.Forms.Panel();
            this.browserStatus = new System.Windows.Forms.Label();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.helpToolTip.SuspendLayout();
            this.launcherBackground.SuspendLayout();
            this.launcherSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderIndicator)).BeginInit();
            this.browserLoadingOverlay.SuspendLayout();
            this.browserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Interval = 1000;
            this.loadingAnimation.Tick += new System.EventHandler(this.loadingAnimation_Tick);
            // 
            // helpToolTip
            // 
            this.helpToolTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInformationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolTip.Name = "helpToolTip";
            this.helpToolTip.Size = new System.Drawing.Size(180, 48);
            // 
            // versionInformationToolStripMenuItem
            // 
            this.versionInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.versionInformationToolStripMenuItem.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.versionInformationToolStripMenuItem.Name = "versionInformationToolStripMenuItem";
            this.versionInformationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.versionInformationToolStripMenuItem.Text = "Version Information";
            this.versionInformationToolStripMenuItem.Click += new System.EventHandler(this.versionInformationToolStripMenuItem_Click);
            this.versionInformationToolStripMenuItem.MouseEnter += new System.EventHandler(this.versionInformationToolStripMenuItem_MouseEnter);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            this.aboutToolStripMenuItem.MouseEnter += new System.EventHandler(this.aboutToolStripMenuItem_MouseEnter);
            // 
            // launcherBackground
            // 
            this.launcherBackground.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.launcherBackground.Controls.Add(this.checkForUpdatesBtn);
            this.launcherBackground.Controls.Add(this.appLabel);
            this.launcherBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.launcherBackground.Location = new System.Drawing.Point(0, 325);
            this.launcherBackground.Name = "launcherBackground";
            this.launcherBackground.Size = new System.Drawing.Size(628, 65);
            this.launcherBackground.TabIndex = 27;
            this.launcherBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.launcherBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // checkForUpdatesBtn
            // 
            this.checkForUpdatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkForUpdatesBtn.FlatAppearance.BorderSize = 0;
            this.checkForUpdatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkForUpdatesBtn.Image = global::Converter.Launcher.App.LauncherAssets.checkforupdates;
            this.checkForUpdatesBtn.Location = new System.Drawing.Point(441, 30);
            this.checkForUpdatesBtn.Name = "checkForUpdatesBtn";
            this.checkForUpdatesBtn.Size = new System.Drawing.Size(181, 23);
            this.checkForUpdatesBtn.TabIndex = 1;
            this.checkForUpdatesBtn.UseVisualStyleBackColor = false;
            this.checkForUpdatesBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.checkForUpdatesBtn.MouseEnter += new System.EventHandler(this.checkForUpdatesBtn_MouseEnter);
            this.checkForUpdatesBtn.MouseLeave += new System.EventHandler(this.checkForUpdatesBtn_MouseLeave);
            this.checkForUpdatesBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.BackColor = System.Drawing.Color.Transparent;
            this.appLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.ForeColor = System.Drawing.Color.White;
            this.appLabel.Location = new System.Drawing.Point(12, 13);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(143, 37);
            this.appLabel.TabIndex = 0;
            this.appLabel.Text = "APP NAME";
            this.appLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.appLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // launcherSidebar
            // 
            this.launcherSidebar.AutoScroll = true;
            this.launcherSidebar.BackColor = System.Drawing.SystemColors.Control;
            this.launcherSidebar.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.launcherSidebar.Controls.Add(this.quitBtn);
            this.launcherSidebar.Controls.Add(this.helpBtn);
            this.launcherSidebar.Controls.Add(this.optionsBtn);
            this.launcherSidebar.Controls.Add(this.launchBtn);
            this.launcherSidebar.Controls.Add(this.loaderIndicator);
            this.launcherSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.launcherSidebar.Location = new System.Drawing.Point(628, 0);
            this.launcherSidebar.Name = "launcherSidebar";
            this.launcherSidebar.Size = new System.Drawing.Size(167, 390);
            this.launcherSidebar.TabIndex = 28;
            this.launcherSidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.launcherSidebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Image = global::Converter.Launcher.App.LauncherAssets.quit;
            this.quitBtn.Location = new System.Drawing.Point(62, 212);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(92, 40);
            this.quitBtn.TabIndex = 28;
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            this.quitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.quitBtn.MouseEnter += new System.EventHandler(this.quitBtn_MouseEnter);
            this.quitBtn.MouseLeave += new System.EventHandler(this.quitBtn_MouseLeave);
            this.quitBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Image = global::Converter.Launcher.App.LauncherAssets.help;
            this.helpBtn.Location = new System.Drawing.Point(72, 170);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(82, 36);
            this.helpBtn.TabIndex = 27;
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            this.helpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.helpBtn.MouseEnter += new System.EventHandler(this.helpBtn_MouseEnter);
            this.helpBtn.MouseLeave += new System.EventHandler(this.helpBtn_MouseLeave);
            this.helpBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // optionsBtn
            // 
            this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.FlatAppearance.BorderSize = 0;
            this.optionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.Image = global::Converter.Launcher.App.LauncherAssets.options;
            this.optionsBtn.Location = new System.Drawing.Point(24, 127);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(132, 38);
            this.optionsBtn.TabIndex = 26;
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            this.optionsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.optionsBtn.MouseEnter += new System.EventHandler(this.optionsBtn_MouseEnter);
            this.optionsBtn.MouseLeave += new System.EventHandler(this.optionsBtn_MouseLeave);
            this.optionsBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // launchBtn
            // 
            this.launchBtn.BackColor = System.Drawing.Color.Transparent;
            this.launchBtn.FlatAppearance.BorderSize = 0;
            this.launchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.launchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.launchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchBtn.Image = global::Converter.Launcher.App.LauncherAssets.launch;
            this.launchBtn.Location = new System.Drawing.Point(42, 85);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(112, 38);
            this.launchBtn.TabIndex = 25;
            this.launchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launchBtn.UseVisualStyleBackColor = false;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            this.launchBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.launchBtn.MouseEnter += new System.EventHandler(this.launchBtn_MouseEnter);
            this.launchBtn.MouseLeave += new System.EventHandler(this.launchBtn_MouseLeave);
            this.launchBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // loaderIndicator
            // 
            this.loaderIndicator.BackColor = System.Drawing.Color.Transparent;
            this.loaderIndicator.Image = global::Converter.Launcher.App.LauncherAssets.loader_48;
            this.loaderIndicator.Location = new System.Drawing.Point(23, 12);
            this.loaderIndicator.Name = "loaderIndicator";
            this.loaderIndicator.Size = new System.Drawing.Size(48, 48);
            this.loaderIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loaderIndicator.TabIndex = 24;
            this.loaderIndicator.TabStop = false;
            this.loaderIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.loaderIndicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // browserLoadingOverlay
            // 
            this.browserLoadingOverlay.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.browserLoadingOverlay.Controls.Add(this.browserStatus);
            this.browserLoadingOverlay.Location = new System.Drawing.Point(0, 0);
            this.browserLoadingOverlay.Name = "browserLoadingOverlay";
            this.browserLoadingOverlay.Size = new System.Drawing.Size(628, 325);
            this.browserLoadingOverlay.TabIndex = 1;
            // 
            // browserStatus
            // 
            this.browserStatus.AutoSize = true;
            this.browserStatus.BackColor = System.Drawing.Color.Transparent;
            this.browserStatus.Font = new System.Drawing.Font("Segoe UI Light", 46F);
            this.browserStatus.ForeColor = System.Drawing.Color.White;
            this.browserStatus.Location = new System.Drawing.Point(200, 108);
            this.browserStatus.Name = "browserStatus";
            this.browserStatus.Size = new System.Drawing.Size(245, 84);
            this.browserStatus.TabIndex = 0;
            this.browserStatus.Text = "Loading";
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.browserLoadingOverlay);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 0);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(628, 325);
            this.browserPanel.TabIndex = 30;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 390);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.launcherBackground);
            this.Controls.Add(this.launcherSidebar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.update_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            this.helpToolTip.ResumeLayout(false);
            this.launcherBackground.ResumeLayout(false);
            this.launcherBackground.PerformLayout();
            this.launcherSidebar.ResumeLayout(false);
            this.launcherSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderIndicator)).EndInit();
            this.browserLoadingOverlay.ResumeLayout(false);
            this.browserLoadingOverlay.PerformLayout();
            this.browserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Timer loadingAnimation;
        private Panel launcherBackground;
        private Panel launcherSidebar;
        private PictureBox loaderIndicator;
        private ContextMenuStrip helpToolTip;
        private ToolStripMenuItem versionInformationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button launchBtn;
        private Button optionsBtn;
        private Button quitBtn;
        private Button helpBtn;
        private Panel browserLoadingOverlay;
        private Label browserStatus;
        private Panel browserPanel;
        private Label appLabel;
        private Button checkForUpdatesBtn;
    }
}

