using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Launcher.App
{
    class GlobalVariables
    {
        private string preferencesFile = Environment.CurrentDirectory + "\\preferences.json";

        public string PreferencesFile { get => preferencesFile; }
    }
}
