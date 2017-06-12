using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs;

using Newtonsoft.Json;
using Converter.Launcher.Lib;

namespace Converter.Launcher.App.Forms
{
    public partial class PreferencesWindow : Form
    {

        GlobalVariables gv = new GlobalVariables();
        DefaultPreferences defprefs = new DefaultPreferences();
        FileFunctions ff = new FileFunctions();
        Preferences preferences = new Preferences();

        bool read_error = false;

        public PreferencesWindow()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            read_error = false;

            if (File.Exists(gv.PreferencesFile))
            {
                try
                {
                    preferences = JsonConvert.DeserializeObject<Preferences>(ff.readPlainTextFile(gv.PreferencesFile));
                    loggingbox.Checked = preferences.EnableLogging;
                    checkforupdatesbox.Checked = preferences.CheckUpdatesOnStartup;
                    launcherSoundsBox.Checked = preferences.LauncherButtonSounds;
                    downloadfolderbox.Text = preferences.UpdaterDownloadFolder;
                    InstallfolderBox.Text = preferences.InstallFolder;
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
                        Preferences_Load(sender, e);
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

                    loggingbox.Checked = defprefs.appPrefs.EnableLogging;
                    checkforupdatesbox.Checked = defprefs.appPrefs.CheckUpdatesOnStartup;
                    launcherSoundsBox.Checked = defprefs.appPrefs.LauncherButtonSounds;
                    downloadfolderbox.Text = defprefs.appPrefs.UpdaterDownloadFolder;
                    InstallfolderBox.Text = defprefs.appPrefs.InstallFolder;
                try
                {
                    ff.writeSettingsJsonFile(gv.PreferencesFile, defprefs.appPrefs);
                }
                catch (Exception ex)
                {
                    DialogResult results = MessageBox.Show("Failed to load '"+ gv.PreferencesFile + "', make sure the file is accessible." + Environment.NewLine + "Exception: " + Environment.NewLine + ex, ex.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (results == DialogResult.Abort)
                    {
                        read_error = true;
                        this.Dispose();
                    }
                    else if (results == DialogResult.Retry)
                    {
                        Preferences_Load(sender, e);
                    }
                }
            }
        }

        private void downloadfolderbtn_Click(object sender, EventArgs e)
        {
            var opendialog = new VistaFolderBrowserDialog();

            DialogResult result = opendialog.ShowDialog();

            if(result == DialogResult.OK && Directory.Exists(opendialog.SelectedPath))
            {
                downloadfolderbox.Text = opendialog.SelectedPath;
            }
            else if(result == DialogResult.OK)
            {
                MessageBox.Show("The specified directory does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void InstallFolderBtn_Click(object sender, EventArgs e)
        {
            var opendialog = new VistaFolderBrowserDialog();

            DialogResult result = opendialog.ShowDialog();

            if (result == DialogResult.OK && Directory.Exists(opendialog.SelectedPath))
            {
                InstallfolderBox.Text = opendialog.SelectedPath;
            }
            else if (result == DialogResult.OK)
            {
                MessageBox.Show("The specified directory does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void PreferencesWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!read_error == true)
            {
                Preferences savingprefs = new Preferences();

                savingprefs.EnableLogging = loggingbox.Checked;
                savingprefs.CheckUpdatesOnStartup = checkforupdatesbox.Checked;
                savingprefs.LauncherButtonSounds = launcherSoundsBox.Checked;
                savingprefs.UpdaterDownloadFolder = downloadfolderbox.Text;
                savingprefs.InstallFolder = InstallfolderBox.Text;

                if(savingprefs.EnableLogging != preferences.EnableLogging || savingprefs.LauncherButtonSounds != preferences.LauncherButtonSounds)
                {
                    MessageBox.Show("Some settings will be applied when the application is restarted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                { 
                    ff.writeSettingsJsonFile(gv.PreferencesFile, savingprefs);
                }
                catch (Exception ex)
                {
                    DialogResult results = MessageBox.Show("Failed to write to '" + gv.PreferencesFile + "', make sure the file is accessible." + Environment.NewLine + "Exception: " + Environment.NewLine + ex, ex.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (results == DialogResult.Abort)
                    {
                        read_error = true;
                        this.Dispose();
                    }
                    else if (results == DialogResult.Retry)
                    {
                        PreferencesWindow_FormClosing(sender, e);
                    }
                }
            }
        }
    }
}
