using System.Collections.Generic;

namespace SettingsPanelPro
{
    // Represents a settings category that may contain nested categories or settings
    public class SettingsCategory
    {
        public string Name { get; set; }
        public Dictionary<string, object> Settings { get; set; } = new();
        public List<SettingsCategory> SubCategories { get; set; } = new();

        public SettingsCategory() { }
        public SettingsCategory(string name)
        {
            Name = name;
        }
    }
}
