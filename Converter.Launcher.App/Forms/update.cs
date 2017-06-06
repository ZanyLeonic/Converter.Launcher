///================== Void Studios (ZanyLeonic) 2015 ==================
/// PURPOSE: The main UI of the program.
/// Version: 0.1
/// Created by ZanyLeonic (Leo Durrant) 15/12/15
///====================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSUpdater;
using POSUpdaterLib;

namespace POSUpdater.Forms
{
    public partial class update : Form
    {
        /// The Uri that leads to the release notes page.
        private Uri releaseNotesUri = new Uri("http://voidstudiosdev.github.io/ProjectOminous-Updater/versioninfo/");

        public update()
        {
            InitializeComponent();
        }

        //External objects
        functions func = new functions();

        private void refreshReleaseInfoBtn_Click(object sender, EventArgs e)
        {
            // Refreshes the web browser control.
            releaseNotes.Refresh();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            about About = new about();
            // Shows the About dialog
            About.Show();
        }

        private void update_Load(object sender, EventArgs e)
        {
            string gamefolder = func.GetSourcemodsPath() + "\\projectominous";

            // Debugging. Checking if the functions work.
            // MessageBox.Show(func.GetSourcemodsPath());
            // string GamefolderExists = func.ProjectOminousModFolderExists().ToString();
            // MessageBox.Show(GamefolderExists);

            releaseNotes.IsWebBrowserContextMenuEnabled = false;
            releaseNotes.Navigate(releaseNotesUri);

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
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            localVersionBox.Text = "Updating...";
            gitVersionBox.Text = "Updating...";
            localVersionBox.Text = func.GetLocalVersion();
            gitVersionBox.Text = func.GetOnlineGitVersion();
        }

        private void browseDir_Click(object sender, EventArgs e)
        {
            installPath.Text = func.browseFolder(func.GetSourcemodsPath());
        }
    }
}