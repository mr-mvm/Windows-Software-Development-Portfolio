using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsPanelPro
{
    public partial class SettingsForm : MaterialForm
    {
        private SettingsManager settingsManager;
        private readonly MaterialSkinManager skinManager;

        public SettingsForm()
        {
            InitializeComponent();

            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            settingsManager = new SettingsManager("settings.json");

            PopulateCategoryCombo();

            ApplySettingsToUI();

            comboCategory.SelectedIndexChanged += ComboCategory_SelectedIndexChanged;
            btnSave.Click += BtnSave_Click;
            btnLoad.Click += BtnLoad_Click;
            btnReset.Click += BtnReset_Click;
            btnSync.Click += BtnSync_Click;
            toggleTheme.CheckedChanged += ToggleTheme_CheckedChanged;
        }

        private void PopulateCategoryCombo()
        {
            comboCategory.Items.Clear();
            foreach (var cat in settingsManager.RootCategory.SubCategories)
                comboCategory.Items.Add(cat.Name);
            if (comboCategory.Items.Count > 0)
                comboCategory.SelectedIndex = 0;
        }

        private void ApplySettingsToUI()
        {
            if (comboCategory.SelectedItem == null) return;

            var categoryName = comboCategory.SelectedItem.ToString();
            var cat = settingsManager.RootCategory.SubCategories.FirstOrDefault(c => c.Name == categoryName);
            if (cat == null) return;

            // Clear fields before applying
            txtKey.Text = "";
            txtValue.Text = "";

            // For demo: show first setting key and value
            if (cat.Settings.Count > 0)
            {
                var kv = cat.Settings.First();
                txtKey.Text = kv.Key;
                txtValue.Text = kv.Value?.ToString() ?? "";
            }

            // Theme
            toggleTheme.Checked = cat.Settings.ContainsKey("Theme") && cat.Settings["Theme"].ToString() == "Dark";
            ApplyTheme();
        }

        private void SaveCurrentSettings()
        {
            if (comboCategory.SelectedItem == null) return;
            var categoryName = comboCategory.SelectedItem.ToString();
            var cat = settingsManager.RootCategory.SubCategories.FirstOrDefault(c => c.Name == categoryName);
            if (cat == null) return;

            // Validate key and value
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Key cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save value as string (you can expand to handle typed data)
            cat.Settings[txtKey.Text] = txtValue.Text.Trim();

            settingsManager.Save();
            MessageBox.Show("Settings saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySettingsToUI();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveCurrentSettings();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            settingsManager.Load();
            PopulateCategoryCombo();
            ApplySettingsToUI();
            MessageBox.Show("Settings loaded!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            settingsManager.ResetDefaults();
            PopulateCategoryCombo();
            ApplySettingsToUI();
            MessageBox.Show("Settings reset to defaults.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnSync_Click(object sender, EventArgs e)
        {
            btnSync.Enabled = false;
            bool result = await settingsManager.SyncToCloudAsync();
            btnSync.Enabled = true;
            MessageBox.Show(result ? "Cloud sync successful!" : "Cloud sync failed.", "Sync Status",
                MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void ToggleTheme_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            skinManager.Theme = toggleTheme.Checked
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;

            Invalidate();
        }
    }
}
