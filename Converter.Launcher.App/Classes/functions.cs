///================== Void Studios (ZanyLeonic) 2015 ==================
/// PURPOSE: Holds all the programs functions.
/// Version: 0.1
/// Created by ZanyLeonic (Leo Durrant) 16/12/15
///====================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;
using System.Windows.Forms;
using POSUpdater;
using POSUpdater.Forms;

namespace POSUpdaterLib
{
    /// <summary>
    /// Holds all the programs functions.
    /// </summary>
    class functions
    {
        /// Supplies the URL of the version on Git
        private Uri versionFileURL = new Uri("http://voidstudiosdev.github.io/ProjectOminous-Updater/versioninfo/version.inf");

       /// <summary>
       /// Gets the sourcemod folder path.
       /// </summary>
       /// <returns>Returns the folder path if successful, returns null if fails.</returns>
        public string GetSourcemodsPath()
        {
            try
            {
                // Opening the key holding the keyvalue we want.
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam"))
                {
                    if (key != null)
                    {
                       // Object ModInstallPath = key.GetValue("SourceModInstallPath");
                        // Getting the SourceModInstallPath varible to get the sourcemods folder path.
                        String ModInstallPath = (string)key.GetValue("SourceModInstallPath");
                        if (ModInstallPath != null)
                        {
                            //String sourcemodpath = new String(ModInstallPath as char[]); //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                            // Returning the value as a string to be used.
                            return ModInstallPath;
                        }
                    }
                    return null;
                }
            }
            catch (Exception e)  // Catches an exeception if it fails to get the registry key.
            {
                Debug.WriteLine("Exception while trying to read SourceModInstallPath registry value.");
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.InnerException);
                Debug.WriteLine("returning null.");
                MessageBox.Show("Exception while trying to read SourceModInstallPath registry value.", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message);
                return null;
            }
        }
        
        /// <summary>
        ///  Checks if the game folder exists in the sourcemods folder on the computer.
        /// </summary>
        /// <returns>Returns true if found, false if not.</returns>
       public bool ProjectOminousModFolderExists()
       {

           string sourcemodfolder = GetSourcemodsPath();
           string gamefolder = sourcemodfolder + "\\projectominous";

           if (Directory.Exists(gamefolder))
           {
               Debug.WriteLine("Found: " + gamefolder + ".");
               Debug.WriteLine("returning true");
               return true;
           }
           else
           {
               Debug.WriteLine("Could not find: " + gamefolder + ".");
               Debug.WriteLine("returing false");
               return false;
           }
       }
      
       /// <summary>
       ///  Gets the version information from GitHub.
       /// </summary>
       /// <returns>Returns the version number if is able to, returns "N/A" if fails.</returns>
       public string GetOnlineGitVersion()
       {

           WebRequest Request;
           WebResponse Response;
           StreamReader Stream;
           try
           {
               Request = HttpWebRequest.Create(versionFileURL);
               Response = Request.GetResponse();
               Stream = new StreamReader(Response.GetResponseStream());
               
               string ver = Stream.ReadToEnd();
               return ver;
           }
           catch (Exception ex)
           {
               Debug.WriteLine("Exception while trying to read: " + versionFileURL + ".");
               Debug.WriteLine(ex.Message);
               Debug.WriteLine(ex.InnerException);

               MessageBox.Show("Exception while trying to read: " + versionFileURL + ".");
               MessageBox.Show(ex.Message);
               Debug.WriteLine("returning N/A.");

               return "N/A";
           }
       }

        /// <summary>
        /// Reads the local version of the mod.
        /// </summary>
        /// <returns>The version of the mod on the local computer. Returns "N/A" if fails.</returns>
       public string GetLocalVersion()
       {
           /// 
           string sourcemodfolder = GetSourcemodsPath();
           string versionFile = sourcemodfolder + "\\projectominous\\version.inf";

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
            catch (Exception e)
           {
                Debug.WriteLine("Exception while trying to open: " + versionFile + ".");
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.InnerException);

                MessageBox.Show("Exception while trying to open: " + versionFile + ".");
                MessageBox.Show(e.Message);

                return "N/A";
           }
       }

        /// <summary>
        ///  Opens the specified path or link.
        /// </summary>
        /// <param name="path">The specified location</param>
       public void OpenUri(string path)
       {
           // If anything goes wrong, it will be caught.
           try
           {
               Process.Start(path);
           }
           catch (Exception e)
           {
               Debug.WriteLine("Exception while trying to open: " + path + ".");
               Debug.WriteLine(e.Message);
               Debug.WriteLine(e.InnerException);

               MessageBox.Show("Exception while trying to open: " + path + ".");
               MessageBox.Show(e.Message);
           }
       }

        /// <summary>
        /// Picks folders.
        /// </summary>
        /// <returns>Returns the selected path.</returns>
       public string browseFolder(string path)
       {
           FolderBrowserDialog folderPicker = new FolderBrowserDialog();
           folderPicker.SelectedPath = path;
           folderPicker.Description = "Select the projectominous game folder.";
           
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
        /// Checks if the local version of the mod is outdated compared to the GitHub version.
        /// </summary>
        /// <returns>
        /// Returns a status code.
        /// Status codes:
        ///  1 : Local version is outdated compared to the Git version. This usually means an update is available.
        ///  0 : Local version is up to date compared to the Git version.
        /// -1 : Failed to convert version numbers to floats.
        /// -2 : Local version is bigger than the Git version. This will never happen, unless if someone has messed with the version number or you are using a development/preview version.
        /// </returns>
       public int localVersionOutdated()
       {
           float localVersion;
           float gitVersion;

           try
           {
               localVersion = float.Parse(GetLocalVersion());
               gitVersion = float.Parse(GetOnlineGitVersion());
           }
           catch (Exception e)
           {
               Debug.WriteLine("Failed to parse versions into a float.");
               Debug.WriteLine(e.Message);
               Debug.WriteLine(e.InnerException);

               MessageBox.Show("Failed to parse versions into a float.");
               MessageBox.Show(e.Message);

               Debug.WriteLine("returning -1...");
               return -1;
           }

           if (localVersion < gitVersion)
           {
               Debug.WriteLine("returning 1...");
               return 1;
           }
           else if (localVersion == gitVersion)
           {
               Debug.WriteLine("returning 0...");
               return 0;
           }
           else
           {
               Debug.WriteLine("returning -2...");
               return -2;
           }
       }
    }
}