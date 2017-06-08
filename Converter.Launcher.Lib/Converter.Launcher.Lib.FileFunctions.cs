using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Converter.Launcher.Lib
{
    public class FileFunctions
    {
        /// <summary>
        /// Reads the file specified as plain text using UTF-8 encoding.
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <returns>Content of the file.</returns>
        public string readPlainTextFile(string path)
        {
            var textStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var textReader = new StreamReader(textStream, Encoding.UTF8))
            {
               return textReader.ReadToEnd();
            }
        }

        /// <summary>
        ///  Writes the following settings the path specified with the preferences.
        /// </summary>
        /// <param name="path">Path to write the JSON.</param>
        /// <param name="prefs">The preferences to set in the JSON.</param>
        public void writeSettingsJsonFile(string path, Preferences prefs)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(prefs));

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, prefs);
            }
        }

        /// <summary>
        /// Picks folders.
        /// </summary>
        /// <param name="path">The path to start on.</param>
        /// <param name="description">The description on the browse folder window.</param>
        /// <returns>Returns the selected path.</returns>
        public string browseFolder(string path, string description)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();
            folderPicker.SelectedPath = path;
            folderPicker.Description = description;

            if (folderPicker.ShowDialog() == DialogResult.OK)
            {
                return folderPicker.SelectedPath;
            }
            else
            {
                return folderPicker.SelectedPath;
            }
        }

        /// <summary>
        /// Reads the local version of the mod.
        /// </summary>
        /// <param name="path">Path to the version.</param>
        /// <returns>The version of the mod on the local computer. Returns null if fails.</returns>
        public string GetLocalVersion(string path)
        {
            string versionFile = path + "\\data\\version.inf";

            try
            {
                // Open the text file using a stream reader.
                using (StreamReader reader = new StreamReader(versionFile))
                {
                    // Read the stream to a string, and write the string to the console.
                    string version = reader.ReadToEnd();

                    return version;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while trying to open: " + versionFile + ".");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);

                MessageBox.Show("Exception while trying to open: " + versionFile + "." + Environment.NewLine + ex.Message);

                return null;
            }
        }
    }
}
