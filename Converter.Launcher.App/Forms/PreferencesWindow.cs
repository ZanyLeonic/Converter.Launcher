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

using Newtonsoft.Json;
using Converter.Launcher.Lib;

namespace Converter.Launcher.App.Forms
{
    public partial class PreferencesWindow : Form
    {

        public string PreferencesFile = Environment.CurrentDirectory + "\\preferences.json";

        public PreferencesWindow()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            FileFunctions ff = new FileFunctions();

            if (File.Exists(PreferencesFile))
            {
                Preferences preferences = JsonConvert.DeserializeObject<Preferences>(ff.readPlainTextFile(PreferencesFile));
            }
            else
            {
                Preferences prefs = new Preferences
                {
                    EnableLogging = true,
                    CheckUpdatesOnStartup = true,
                    UpdaterDownloadFolder = Environment.CurrentDirectory + "\\downloads",
                    InstallFolder = Environment.CurrentDirectory + "\\Converter"
                };

                /// If the download folder doesn't exist now, create it!
                if (!Directory.Exists(prefs.UpdaterDownloadFolder))
                {
                    Directory.CreateDirectory(prefs.UpdaterDownloadFolder);
                }

                loggingCheck.Checked = prefs.EnableLogging;
                checkforupdatesbox.Checked = prefs.CheckUpdatesOnStartup;
                downloadfolderbox.Text = prefs.UpdaterDownloadFolder;
                InstallfolderBox.Text = prefs.InstallFolder;

                ff.writeSettingsJsonFile(PreferencesFile, prefs);
            }

        }

        private void loggingCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkforupdatesbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void downloadfolderbtn_Click(object sender, EventArgs e)
        {

        }

        private void InstallFolderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
