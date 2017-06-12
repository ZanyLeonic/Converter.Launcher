using System;

namespace Converter.Launcher.Lib
{
    public class Preferences
    {
        public bool EnableLogging           { get; set; }
        public bool CheckUpdatesOnStartup   { get; set; }
        public bool LauncherButtonSounds    { get; set; }
        public string UpdaterDownloadFolder { get; set; }
        public string InstallFolder         { get; set; }
    }

    public class VersionInfo
    {
        public string version { get; }
    }

    public class DefaultPreferences
    {
        public Preferences appPrefs = new Preferences
        {
            EnableLogging = true,
            CheckUpdatesOnStartup = true,
            LauncherButtonSounds = true,
            UpdaterDownloadFolder = Environment.CurrentDirectory + "\\downloads",
            InstallFolder = Environment.CurrentDirectory + "\\Converter"
        };
    }
}
