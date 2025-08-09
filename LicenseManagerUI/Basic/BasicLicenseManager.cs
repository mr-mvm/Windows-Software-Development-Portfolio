using System;
using System.IO;
using System.Text.Json;

namespace LicenseManagerBasic
{
    public class LicenseData
    {
        public string LicenseKey { get; set; }
        public bool IsActive { get; set; }
    }

    public class LicenseManager
    {
        private readonly string filePath;
        private LicenseData licenseData;

        public LicenseManager(string path)
        {
            filePath = path;
            Load();
        }

        public bool IsActive => licenseData?.IsActive ?? false;

        public void Activate(string key)
        {
            licenseData = new LicenseData { LicenseKey = key, IsActive = true };
            Save();
        }

        public void Deactivate()
        {
            licenseData = new LicenseData { LicenseKey = null, IsActive = false };
            Save();
        }

        private void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                licenseData = JsonSerializer.Deserialize<LicenseData>(json);
            }
            else
            {
                licenseData = new LicenseData { LicenseKey = null, IsActive = false };
            }
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(licenseData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
