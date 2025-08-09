using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SettingsPanelBasic
{
    public partial class SettingsForm : MaterialForm
    {
        private SettingsManager settingsManager;

        public SettingsForm()
        {
            InitializeComponent();

            // Setup MaterialSkin manager
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            settingsManager = new SettingsManager("settings.json");

            LoadSettingsToUI();
        }

        private void LoadSettingsToUI()
        {
            toggleEnable.Checked = settingsManager.Settings.EnableFeature;
            sliderVolume.Value = settingsManager.Settings.Volume;
            comboOptions.SelectedItem = settingsManager.Settings.SelectedOption;
            txtUsername.Text = settingsManager.Settings.Username;
        }

        private void SaveSettingsFromUI()
        {
            settingsManager.Settings.EnableFeature = toggleEnable.Checked;
            settingsManager.Settings.Volume = sliderVolume.Value;
            settingsManager.Settings.SelectedOption = comboOptions.SelectedItem?.ToString() ?? "Option1";
            settingsManager.Settings.Username = txtUsername.Text;
            settingsManager.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettingsFromUI();
            MessageBox.Show("Settings saved!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            settingsManager.Load();
            LoadSettingsToUI();
            MessageBox.Show("Settings loaded!");
        }
    }
}
