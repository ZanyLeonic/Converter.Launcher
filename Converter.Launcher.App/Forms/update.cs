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

namespace Converter.Launcher.App.Forms
{
    public partial class Update : Form
    {
        /// The Uri that leads to the release notes page.
        private String releaseNotesUri = "http://voidstudiosdev.github.io/ProjectOminous-Updater/versioninfo/";

        private ChromiumWebBrowser releasenotes;

        public Update()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            CreateBrowser();
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

            prefswindow.Show();
        }
    }
}