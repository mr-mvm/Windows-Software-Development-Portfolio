using System;
using System.IO;
using System.Text.Json;

namespace SettingsPanelEnhanced
{
    public class SettingsData
    {
        public bool EnableFeature { get; set; } = true;
        public int Volume { get; set; } = 50;
        public string SelectedOption { get; set; } = "Option1";
        public string Username { get; set; } = "";
        public bool IsDarkTheme { get; set; } = false;
    }

    public class SettingsManager
    {
        private readonly string filePath;
        public SettingsData Settings { get; private set; }

        public SettingsManager(string path)
        {
            filePath = path;
            Load();
        }

        public void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }
            else
            {
                Settings = new SettingsData();
            }
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void ResetDefaults()
        {
            Settings = new SettingsData();
            Save();
        }
    }
}
