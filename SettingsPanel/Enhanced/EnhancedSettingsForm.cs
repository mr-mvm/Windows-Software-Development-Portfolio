using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SettingsPanelEnhanced
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
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            settingsManager = new SettingsManager("settings.json");

            LoadSettingsToUI();

            // Hook theme toggle event
            toggleTheme.CheckedChanged += ToggleTheme_CheckedChanged;
        }

        private void LoadSettingsToUI()
        {
            toggleEnable.Checked = settingsManager.Settings.EnableFeature;
            sliderVolume.Value = settingsManager.Settings.Volume;
            comboOptions.SelectedItem = settingsManager.Settings.SelectedOption;
            txtUsername.Text = settingsManager.Settings.Username;
            toggleTheme.Checked = settingsManager.Settings.IsDarkTheme;

            ApplyTheme();
        }

        private void SaveSettingsFromUI()
        {
            if (!ValidateInputs())
                return;

            settingsManager.Settings.EnableFeature = toggleEnable.Checked;
            settingsManager.Settings.Volume = sliderVolume.Value;
            settingsManager.Settings.SelectedOption = comboOptions.SelectedItem?.ToString() ?? "Option1";
            settingsManager.Settings.Username = txtUsername.Text.Trim();
            settingsManager.Settings.IsDarkTheme = toggleTheme.Checked;

            settingsManager.Save();
            ApplyTheme();

            MessageBox.Show("Settings saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInputs()
        {
            if (sliderVolume.Value < 0 || sliderVolume.Value > 100)
            {
                MessageBox.Show("Volume must be between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboOptions.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettingsFromUI();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            settingsManager.Load();
            LoadSettingsToUI();
            MessageBox.Show("Settings loaded!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            settingsManager.ResetDefaults();
            LoadSettingsToUI();
            MessageBox.Show("Settings reset to defaults.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Invalidate(); // Refresh UI
        }
    }
}
