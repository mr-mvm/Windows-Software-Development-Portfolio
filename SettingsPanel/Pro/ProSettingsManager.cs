using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SettingsPanelPro
{
    public class SettingsManager
    {
        private readonly string filePath;
        public SettingsCategory RootCategory { get; private set; }

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
                RootCategory = JsonSerializer.Deserialize<SettingsCategory>(json) ?? GetDefaultSettings();
            }
            else
            {
                RootCategory = GetDefaultSettings();
            }
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(RootCategory, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void ResetDefaults()
        {
            RootCategory = GetDefaultSettings();
            Save();
        }

        private SettingsCategory GetDefaultSettings()
        {
            var root = new SettingsCategory("Root");

            var general = new SettingsCategory("General");
            general.Settings["EnableFeature"] = true;
            general.Settings["Username"] = "";

            var display = new SettingsCategory("Display");
            display.Settings["Volume"] = 50;
            display.Settings["Theme"] = "Light";

            var account = new SettingsCategory("Account");
            account.Settings["Email"] = "";
            account.Settings["ReceiveNewsletter"] = true;

            root.SubCategories.Add(general);
            root.SubCategories.Add(display);
            root.SubCategories.Add(account);

            return root;
        }

        // Simulated cloud sync placeholder
        public async Task<bool> SyncToCloudAsync()
        {
            await Task.Delay(1500); // simulate delay
            return true; // pretend sync success
        }
    }
}
