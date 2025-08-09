using System;
using System.IO;
using System.Text.Json;

namespace AboutEnhanced
{
    public class AppConfig
    {
        public bool Activated { get; set; } = true;
        public DateTime? ExpiresOn { get; set; } = DateTime.UtcNow.AddDays(30);
        public string AppName { get; set; } = "MyApp Enhanced";
    }

    public static class ConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AboutEnhanced", "config.json");

        public static AppConfig Load()
        {
            try
            {
                if (!File.Exists(ConfigPath)) return new AppConfig();
                var json = File.ReadAllText(ConfigPath);
                return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }
            catch
            {
                return new AppConfig();
            }
        }

        public static void Save(AppConfig cfg)
        {
            try
            {
                var folder = Path.GetDirectoryName(ConfigPath);
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                var json = JsonSerializer.Serialize(cfg, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigPath, json);
            }
            catch { /* swallow for demo */ }
        }
    }
}
