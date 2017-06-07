using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Launcher.Lib
{
    public class Preferences
    {
        public bool EnableLogging           { get; set; }
        public bool CheckUpdatesOnStartup   { get; set; }
        public string UpdaterDownloadFolder { get; set; }
        public string InstallFolder         { get; set; }
    }
}
