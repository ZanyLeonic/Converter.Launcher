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
using Newtonsoft.Json;

namespace Converter.Launcher.Lib
{
    public class WebFunctions
    {

        /// <summary>
        ///  Reads a online file from the specified URL.
        /// </summary>
        /// <param name="FileURL">The URL of the file to read online.</param>
        /// <returns>Returns the version number if is able to, returns null if fails.</returns>
        public string ReadOnlineFile(Uri FileURL)
        {

            WebRequest Request;
            WebResponse Response;
            StreamReader Stream;
            try
            {
                Request = HttpWebRequest.Create(FileURL);
                Response = Request.GetResponse();
                Stream = new StreamReader(Response.GetResponseStream());

                string ver = Stream.ReadToEnd();
                return ver;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while trying to read: " + FileURL + ".");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);

                MessageBox.Show("Exception while trying to read: " + FileURL + "." + Environment.NewLine + ex.Message);
                Debug.WriteLine("returning null.");

                return null;
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
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while trying to open: " + path + ".");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);

                MessageBox.Show("Exception while trying to open: " + path + "." + Environment.NewLine + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="JSONurl"></param>
        /// <returns></returns>
        public object GetOnlineVersion(string JSONurl)
        {
            string versionJSON = JSONurl;

            try
            {
                VersionInfo ver = JsonConvert.DeserializeObject <VersionInfo>(ReadOnlineFile(new Uri(versionJSON)));

                return ver.version;
            }
            catch (Exception ex)
            {
                return ex;
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
            /*
            float localVersion;
            float gitVersion;

            try
            {
               localVersion = float.Parse(GetLocalVersion());
               gitVersion = float.Parse(GetOnlineGitVersion());
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to parse versions into a float.");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);

                MessageBox.Show("Failed to parse versions into a float." + Environment.NewLine + ex.Message);

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
        */
            return 0;
        }
    }
}

///================== Void Studios (ZanyLeonic) 2015 ==================
/// PURPOSE: Holds all the programs functions.
/// Version: 0.1
/// Created by ZanyLeonic (Leo Durrant) 16/12/15
///====================================================================