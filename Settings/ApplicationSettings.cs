using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace ProTimer.Settings
{
    /// <summary>
    /// Provides a list of settings to be used by the application.
    /// </summary>
    public class ApplicationSettings
    {
        #region Constructor

        public ApplicationSettings()
        {
            LogFilePath = "Log.json";
            AppSettingsPath = "Settings.json";
            ResourcesDirectory = Application.StartupPath + "\\Resources";
        }

        #endregion

        #region Fields

        private string _logFilePath;
        private object _appSettingsPath;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the path to the log file.
        /// </summary>
        [JsonIgnore]
        public string LogFilePath { get; set; }

        /// <summary>
        /// Gets or sets the path to the application's settings file.
        /// </summary>
        [JsonIgnore]
        public string AppSettingsPath { get; set; }

        /// <summary>
        /// Gets or sets the application's Resources directory.
        /// </summary>
        [JsonIgnore]
        public string ResourcesDirectory { get; set; }

        /// <summary>
        /// Gets or sets the number of steps (in milliseconds)  
        /// it takes for the countdown timer to tick.
        /// </summary>
        public int TimerStep { get; set; }

        /// <summary>
        /// Enable logging of all countdowns launched?
        /// </summary>
        public bool LogCountdowns { get; set; } = true;

        /// <summary>
        /// Gets or sets the last countdown that was launched.
        /// </summary>
        public string LastCountdown { get; set; }

        #endregion
    }

    /// <summary>
    /// Helps retrieve and update the application's settings.
    /// </summary>
    public class SettingsManager
    {
        #region Properties

        /// <summary>
        /// Checks whether the log file exists.
        /// </summary>
        public bool LogFileExists { get => File.Exists($"{Settings.ResourcesDirectory}\\{Settings.LogFilePath}"); }

        /// <summary>
        /// Checks whether the application's settings file exists.
        /// </summary>
        public bool AppSettingsExists { get => File.Exists($"{Settings.ResourcesDirectory}\\{Settings.AppSettingsPath}"); }

        /// <summary>
        /// Gets or sets the default application settings.
        /// </summary>
        public ApplicationSettings Settings { get; set; }

        #endregion

        #region Methods

        #region Application Management

        /// <summary>
        /// Reads the default application settings file, 
        /// returning the settings object.
        /// </summary>
        /// <returns>
        /// An <see cref="AppSettings"/> object.
        /// </returns>
        public ApplicationSettings GetAppSettings()
        {
            if (!AppSettingsExists)
                SetAppSettings();

            string path = $"{Settings.ResourcesDirectory}\\{Settings.AppSettingsPath}";

            return JsonConvert.DeserializeObject<ApplicationSettings>(File.ReadAllText(path));
        }

        /// <summary>
        /// Writes to the default application settings file, 
        /// and returns a <see cref="Boolean"/> value indicating whether the
        /// settings have been updated successfully.
        /// </summary>
        /// <returns>
        /// True, if the settings file has been updated,
        /// or False if the settings-update failed.
        /// </returns>
        public bool SetAppSettings()
        {
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                if (!Directory.Exists(Settings.ResourcesDirectory))
                    Directory.CreateDirectory(Settings.ResourcesDirectory);

                string path = $"{Settings.ResourcesDirectory}\\{Settings.AppSettingsPath}";

                File.WriteAllText(path, JsonConvert.SerializeObject(Settings).ToString());

                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #region Logging Management

        /// <summary>
        /// Reads the default log file, 
        /// returning the log object.
        /// </summary>
        /// <returns>
        /// An <see cref="LogRecord"/> object.
        /// </returns>
        public List<LogRecord> GetLogRecords()
        {
            if (!LogFileExists)
                SetLogRecords(new List<LogRecord>());

            string path = $"{Settings.ResourcesDirectory}\\{Settings.LogFilePath}";

            return JsonConvert.DeserializeObject<List<LogRecord>>(File.ReadAllText(path));
        }

        /// <summary>
        /// Writes to the default log file, 
        /// and returns a <see cref="Boolean"/> value indicating whether the
        /// log information has been updated successfully.
        /// </summary>
        /// <returns>
        /// True, if the log file has been updated,
        /// or False if the log-update failed.
        /// </returns>
        public bool SetLogRecords(List<LogRecord> log)
        {
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                string path = $"{Settings.ResourcesDirectory}\\{Settings.LogFilePath}";

                File.WriteAllText(path, JsonConvert.SerializeObject(log).ToString());

                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Creates a new log record to be added to the list of log records.
    /// </summary>
    public class LogRecord
    {
        #region Properties

        /// <summary>
        /// Gets or sets the time the countdown started.
        /// </summary>
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Gets or sets the time the countdown ended.
        /// </summary>
        public DateTime EndedAt { get; set; }

        /// <summary>
        /// Gets or sets the countdown that was set.
        /// </summary>
        public string Countdown { get; set; }

        #endregion
    }
}