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
            this.browserPanel = new System.Windows.Forms.Panel();
            this.launcherBackground = new System.Windows.Forms.Panel();
            this.launcherSidebar = new System.Windows.Forms.Panel();
            this.loaderIndicator = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.quitBtn = new System.Windows.Forms.PictureBox();
            this.optionsBtn = new System.Windows.Forms.PictureBox();
            this.readmeBtn = new System.Windows.Forms.PictureBox();
            this.browserLoadingOverlay = new System.Windows.Forms.Panel();
            this.browserStatus = new System.Windows.Forms.Label();
            this.loaderBox = new System.Windows.Forms.PictureBox();
            this.browserPanel.SuspendLayout();
            this.launcherSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readmeBtn)).BeginInit();
            this.browserLoadingOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Interval = 1000;
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.browserLoadingOverlay);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 0);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(795, 390);
            this.browserPanel.TabIndex = 29;
            // 
            // launcherBackground
            // 
            this.launcherBackground.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.launcherBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.launcherBackground.Location = new System.Drawing.Point(0, 325);
            this.launcherBackground.Name = "launcherBackground";
            this.launcherBackground.Size = new System.Drawing.Size(628, 65);
            this.launcherBackground.TabIndex = 27;
            // 
            // launcherSidebar
            // 
            this.launcherSidebar.AutoScroll = true;
            this.launcherSidebar.BackColor = System.Drawing.SystemColors.Control;
            this.launcherSidebar.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.launcherSidebar.Controls.Add(this.loaderIndicator);
            this.launcherSidebar.Controls.Add(this.playBtn);
            this.launcherSidebar.Controls.Add(this.quitBtn);
            this.launcherSidebar.Controls.Add(this.optionsBtn);
            this.launcherSidebar.Controls.Add(this.readmeBtn);
            this.launcherSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.launcherSidebar.Location = new System.Drawing.Point(628, 0);
            this.launcherSidebar.Name = "launcherSidebar";
            this.launcherSidebar.Size = new System.Drawing.Size(167, 390);
            this.launcherSidebar.TabIndex = 28;
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
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.Image = global::Converter.Launcher.App.LauncherAssets.play;
            this.playBtn.Location = new System.Drawing.Point(64, 108);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(92, 38);
            this.playBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playBtn.TabIndex = 19;
            this.playBtn.TabStop = false;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.Image = global::Converter.Launcher.App.LauncherAssets.quit;
            this.quitBtn.Location = new System.Drawing.Point(64, 235);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(92, 38);
            this.quitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.quitBtn.TabIndex = 22;
            this.quitBtn.TabStop = false;
            // 
            // optionsBtn
            // 
            this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.Image = global::Converter.Launcher.App.LauncherAssets.options;
            this.optionsBtn.Location = new System.Drawing.Point(23, 152);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(133, 37);
            this.optionsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.optionsBtn.TabIndex = 20;
            this.optionsBtn.TabStop = false;
            // 
            // readmeBtn
            // 
            this.readmeBtn.BackColor = System.Drawing.Color.Transparent;
            this.readmeBtn.Image = global::Converter.Launcher.App.LauncherAssets.readme;
            this.readmeBtn.Location = new System.Drawing.Point(6, 195);
            this.readmeBtn.Name = "readmeBtn";
            this.readmeBtn.Size = new System.Drawing.Size(150, 34);
            this.readmeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.readmeBtn.TabIndex = 21;
            this.readmeBtn.TabStop = false;
            // 
            // browserLoadingOverlay
            // 
            this.browserLoadingOverlay.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.background;
            this.browserLoadingOverlay.Controls.Add(this.browserStatus);
            this.browserLoadingOverlay.Controls.Add(this.loaderBox);
            this.browserLoadingOverlay.Location = new System.Drawing.Point(0, 0);
            this.browserLoadingOverlay.Name = "browserLoadingOverlay";
            this.browserLoadingOverlay.Size = new System.Drawing.Size(628, 325);
            this.browserLoadingOverlay.TabIndex = 0;
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
            // loaderBox
            // 
            this.loaderBox.BackColor = System.Drawing.Color.Transparent;
            this.loaderBox.BackgroundImage = global::Converter.Launcher.App.LauncherAssets.loader_48;
            this.loaderBox.Location = new System.Drawing.Point(146, 130);
            this.loaderBox.Name = "loaderBox";
            this.loaderBox.Size = new System.Drawing.Size(48, 48);
            this.loaderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loaderBox.TabIndex = 23;
            this.loaderBox.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 390);
            this.Controls.Add(this.launcherBackground);
            this.Controls.Add(this.launcherSidebar);
            this.Controls.Add(this.browserPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.update_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            this.browserPanel.ResumeLayout(false);
            this.launcherSidebar.ResumeLayout(false);
            this.launcherSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readmeBtn)).EndInit();
            this.browserLoadingOverlay.ResumeLayout(false);
            this.browserLoadingOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox readmeBtn;
        private Timer loadingAnimation;
        private Panel launcherBackground;
        private Panel launcherSidebar;
        private PictureBox loaderIndicator;
        private PictureBox playBtn;
        private PictureBox quitBtn;
        private PictureBox optionsBtn;
        private PictureBox loaderBox;
        private Panel browserPanel;
        private Panel browserLoadingOverlay;
        private Label browserStatus;
    }
}

