using System;
using System.IO;
using System.Text.Json;

namespace LicenseManagerPro
{
    public class LicenseData
    {
        public string LicenseKey { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsTrial { get; set; }
        public DateTime TrialExpiryDate { get; set; }
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
        public DateTime? ExpiryDate => licenseData?.ExpiryDate;
        public bool IsTrial => licenseData?.IsTrial ?? false;
        public DateTime TrialExpiryDate => licenseData?.TrialExpiryDate ?? DateTime.MinValue;

        public void Activate(string key, DateTime expiryDate)
        {
            licenseData = new LicenseData
            {
                LicenseKey = key,
                IsActive = true,
                ExpiryDate = expiryDate,
                IsTrial = false
            };
            Save();
        }

        public void Deactivate()
        {
            licenseData = new LicenseData
            {
                LicenseKey = null,
                IsActive = false,
                ExpiryDate = null,
                IsTrial = false
            };
            Save();
        }

        public void StartTrial(DateTime trialExpiry)
        {
            licenseData = new LicenseData
            {
                LicenseKey = null,
                IsActive = false,
                ExpiryDate = null,
                IsTrial = true,
                TrialExpiryDate = trialExpiry
            };
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
                licenseData = new LicenseData();
            }
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(licenseData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
