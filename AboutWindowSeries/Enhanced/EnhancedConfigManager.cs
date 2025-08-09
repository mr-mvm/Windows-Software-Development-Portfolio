using System;
using System.IO;

namespace AboutEnhanced
{
    public class ConfigManager
    {
        private readonly string configFilePath;

        public ConfigManager(string filePath)
        {
            configFilePath = filePath;
        }

        public string ReadConfig()
        {
            if (File.Exists(configFilePath))
            {
                return File.ReadAllText(configFilePath);
            }
            return string.Empty;
        }

        public void WriteConfig(string data)
        {
            File.WriteAllText(configFilePath, data);
        }
    }
}
