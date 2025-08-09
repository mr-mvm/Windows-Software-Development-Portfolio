using System;
using System.Windows.Forms;

namespace AboutEnhanced
{
    public partial class AboutForm : Form
    {
        private ConfigManager configManager;

        public AboutForm()
        {
            InitializeComponent();
            configManager = new ConfigManager("config.txt");
            LoadConfigData();
        }

        private void LoadConfigData()
        {
            string savedInfo = configManager.ReadConfig();
            if (!string.IsNullOrWhiteSpace(savedInfo))
            {
                lblInfo.Text = savedInfo;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            configManager.WriteConfig(txtInfo.Text);
            MessageBox.Show("Information saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
