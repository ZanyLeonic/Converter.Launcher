///================== Void Studios (ZanyLeonic) 2015 ==================
/// PURPOSE: The main UI of the program.
/// Version: 0.1
/// Created by ZanyLeonic (Leo Durrant) 15/12/15
///====================================================================
using System;
using System.Windows.Forms;
using CefSharp.WinForms.Internals;
using Converter.Launcher.Lib;
using CefSharp.WinForms;
using CefSharp;
using log4net;
using System.Reflection;
using System.Drawing;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Converter.Launcher.App.Forms
{
    public partial class Update : Form
    {

        delegate void SetBoolDelegate(bool parameter);

        /// The Uri that leads to the release notes page.
        private String releaseNotesUri = LauncherAssets.releasenotesURL;
        private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private ChromiumWebBrowser releasenotes;

        System.Drawing.Point NewPoint = new System.Drawing.Point();
        int X = 0;
        int Y = 0;

        System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();

        FileFunctions ff = new FileFunctions();
        WebFunctions wb = new WebFunctions();

        DefaultPreferences defprefs = new DefaultPreferences();
        GlobalVariables gv = new GlobalVariables();

        public Preferences preferences = new Preferences();
        DefaultPreferences DefaultPreferences = new DefaultPreferences();

        bool read_error = false;
        int prefsvers = -1;

        public Update()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.log.Info("Main window loading...");

            CreateBrowser();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            releasenotes.LoadingStateChanged += OnLoadingStateChanged;

            checkForUpdatesBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            launchBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            optionsBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            helpBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            quitBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            read_error = false;

            if (File.Exists(gv.PreferencesFile))
            {
                try
                {
                    preferences = JsonConvert.DeserializeObject<Preferences>(ff.readPlainTextFile(gv.PreferencesFile));

                    prefsvers = 0;
                }
                catch (Exception ex)
                {
                    DialogResult results = MessageBox.Show("Failed to load '" + gv.PreferencesFile + "', make sure the file is accessible." + Environment.NewLine + "Exception: " + Environment.NewLine + ex, ex.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (results == DialogResult.Abort)
                    {
                        read_error = true;
                        this.Dispose();
                    }
                    else if (results == DialogResult.Retry)
                    {
                        OnLoad(sender, e);
                    }
                }

            }
            else
            {
                /// If the download folder doesn't exist now, create it!
                if (!Directory.Exists(defprefs.appPrefs.UpdaterDownloadFolder))
                {
                    Directory.CreateDirectory(defprefs.appPrefs.UpdaterDownloadFolder);
                }

                try
                {
                    ff.writeSettingsJsonFile(gv.PreferencesFile, defprefs.appPrefs);
                    prefsvers = 1;
                }
                catch (Exception ex)
                {
                    DialogResult results = MessageBox.Show("Failed to load '" + gv.PreferencesFile + "', make sure the file is accessible." + Environment.NewLine + "Exception: " + Environment.NewLine + ex, ex.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (results == DialogResult.Abort)
                    {
                        read_error = true;
                        this.Dispose();
                    }
                    else if (results == DialogResult.Retry)
                    {
                        OnLoad(sender, e);
                    }
                }
            }

        appLabel.Parent = launcherBackground;
            appLabel.Text = LauncherAssets.AppName;

            checkForUpdatesBtn.Parent = launcherBackground;

            loadingAnimation.Start();
        }

        private void CreateBrowser()
        {
            releasenotes = new ChromiumWebBrowser(releaseNotesUri)
            {
                Dock = DockStyle.Fill,
            };

            this.browserPanel.Controls.Add(releasenotes);

            /*
            releasenotes.LoadingStateChanged += OnBrowserLoadingStateChanged;
            releasenotes.ConsoleMessage += OnBrowserConsoleMessage;
            releasenotes.StatusMessage += OnBrowserStatusMessage;
            releasenotes.TitleChanged += OnBrowserTitleChanged;
            releasenotes.AddressChanged += OnBrowserAddressChanged;
            */
        }

        protected void CheckForUpdates()
        {
           
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBrowserLoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //External objects
        // functions func = new functions();

        private void refreshReleaseInfoBtn_Click(object sender, EventArgs e)
        {
            // Refreshes the web browser control.
            releasenotes.Reload();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About About = new About();
            // Shows the About dialog
            About.Show();
        }

        private void update_Load(object sender, EventArgs e)
        {
            //string gamefolder = func.GetSourcemodsPath() + "\\projectominous";

            // Debugging. Checking if the functions work.
            // MessageBox.Show(func.GetSourcemodsPath());
            // string GamefolderExists = func.ProjectOminousModFolderExists().ToString();
            // MessageBox.Show(GamefolderExists);
           
            //releaseNotes.IsWebBrowserContextMenuEnabled = false;
            /*
            if (func.ProjectOminousModFolderExists())
            {
                installPath.Text = "Updating...";
                installPath.Text = gamefolder;
            }
            else
            {
                MessageBox.Show("We could not find the game folder for projectoninous. Ethier it's not installed or you will have to browse to it when the program loads.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                installPath.Text = "Press the '...' button to choose the game folder...";
            }

            localVersionBox.Text = "Updating...";
            localVersionBox.Text = func.GetLocalVersion();
            */
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            /*
            localVersionBox.Text = "Updating...";
            gitVersionBox.Text = "Updating...";
            localVersionBox.Text = func.GetLocalVersion();
            gitVersionBox.Text = func.GetOnlineGitVersion();
            */
        }

        private void browseDir_Click(object sender, EventArgs e)
        {
           // installPath.Text = func.browseFolder(func.GetSourcemodsPath());
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesWindow prefswindow = new PreferencesWindow();

            prefswindow.ShowDialog();
        }

        private void Update_MouseDown(object sender, MouseEventArgs e)
        {
            X = Control.MousePosition.X - this.Location.X;
            Y = Control.MousePosition.Y - this.Location.Y;
        }

        private void Update_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NewPoint = Control.MousePosition;
                NewPoint.X -= (X);
                NewPoint.Y -= (Y);
                this.Location = NewPoint;
            }
        }

        private void playBtnFocus()
        {
            if (preferences.LauncherButtonSounds)
            {
                player.Stream = LauncherAssets.menu_focus;
                player.Play();
            }
        }

        private void playBtnClick()
        {
            if (preferences.LauncherButtonSounds)
            {
                player.Stream = LauncherAssets.menu_accept;
                player.Play();
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            playBtnClick();
        }

        private void launchBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBtn.Image = LauncherAssets.launch_hover;
            playBtnFocus();
        }

        private void launchBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBtn.Image = LauncherAssets.launch;
        }

        private void optionsBtn_MouseEnter(object sender, EventArgs e)
        {
            optionsBtn.Image = LauncherAssets.options_hover;
            playBtnFocus();
        }

        private void optionsBtn_MouseLeave(object sender, EventArgs e)
        {
            optionsBtn.Image = LauncherAssets.options;
        }

        private void helpBtn_MouseEnter(object sender, EventArgs e)
        {
            helpBtn.Image = LauncherAssets.help_hover;
            playBtnFocus();
        }

        private void helpBtn_MouseLeave(object sender, EventArgs e)
        {
            helpBtn.Image = LauncherAssets.help;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            playBtnClick();
            this.Dispose();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            playBtnClick();
            helpToolTip.Show(Cursor.Position);
        }

        private void quitBtn_MouseEnter(object sender, EventArgs e)
        {
            quitBtn.Image = LauncherAssets.quit_hover;
            playBtnFocus();
        }

        private void quitBtn_MouseLeave(object sender, EventArgs e)
        {
            quitBtn.Image = LauncherAssets.quit;
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            PreferencesWindow prefwindow = new PreferencesWindow();
            prefwindow.Left = this.Left + this.Width;
            prefwindow.Top = this.Top + (this.Height - prefwindow.Height) / 2;
            
            playBtnClick();
            prefwindow.ShowDialog();
        }

        private void versionInformationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            playBtnFocus();
        }

        private void aboutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            playBtnFocus();
        }

        private void versionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playBtnClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();

            playBtnClick();
            ab.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            launchBtn.Image = LauncherAssets.launch_hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            launchBtn.Image = LauncherAssets.launch;
        }

        private void loadingAnimation_Tick(object sender, EventArgs e)
        {
            if (browserStatus.Text == "Loading")
            {
                browserStatus.Text = "Loading.";
            }
            else if (browserStatus.Text == "Loading.")
            {
                browserStatus.Text = "Loading..";
            }
            else if (browserStatus.Text == "Loading..")
            {
                browserStatus.Text = "Loading...";
            }
            else if (browserStatus.Text == "Loading...")
            {
                browserStatus.Text = "Loading";
            }
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                this.SetBrowserLoadingOverlayVisiblity(false);
                this.SetLoaderVisiblity(false);
                this.SetLoader2Visiblity(false);
            }
            else
            {
                this.SetBrowserLoadingOverlayVisiblity(true);
                this.SetLoaderVisiblity(true);
                this.SetLoader2Visiblity(true);
            }
        }

        private void SetBrowserLoadingOverlayVisiblity(bool state)
        {
            if (this.browserLoadingOverlay.InvokeRequired)
            {
                SetBoolDelegate d = new SetBoolDelegate(SetBrowserLoadingOverlayVisiblity);
                this.Invoke(d, new object[] { state });
            }
            else
            {
                this.browserLoadingOverlay.Visible = state;
            }
        }

        private void SetLoaderVisiblity(bool state)
        {
            /*
            if (this.loaderBox.InvokeRequired)
            {
                SetBoolDelegate d = new SetBoolDelegate(SetLoaderVisiblity);
                this.Invoke(d, new object[] { state });
            }
            else
            {
                this.loaderBox.Visible = state;
            }
            */
        }

        private void SetLoader2Visiblity(bool state)
        {
            if (this.loaderIndicator.InvokeRequired)
            {
                SetBoolDelegate d = new SetBoolDelegate(SetLoader2Visiblity);
                this.Invoke(d, new object[] { state });
            }
            else
            {
                this.loaderIndicator.Visible = state;
            }
        }

        private void checkForUpdatesBtn_MouseEnter(object sender, EventArgs e)
        {
            checkForUpdatesBtn.Image = LauncherAssets.checkforupdates_hover;
            playBtnFocus();
        }

        private void checkForUpdatesBtn_MouseLeave(object sender, EventArgs e)
        {
            checkForUpdatesBtn.Image = LauncherAssets.checkforupdates;
        }

        private void checkForUpdatesBtn_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

    }
}