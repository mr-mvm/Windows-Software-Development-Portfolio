using System;
using System.Windows.Forms;

namespace LicenseManagerBasic
{
    public partial class LicenseForm : Form
    {
        private LicenseManager licenseManager;

        public LicenseForm()
        {
            InitializeComponent();
            licenseManager = new LicenseManager("license.json");
            UpdateStatus();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string key = txtLicenseKey.Text.Trim();
            if (!string.IsNullOrEmpty(key))
            {
                licenseManager.Activate(key);
                UpdateStatus();
            }
            else
            {
                MessageBox.Show("Please enter a license key.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            licenseManager.Deactivate();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblStatus.Text = licenseManager.IsActive ? "Status: Active" : "Status: Inactive";
        }
    }
}
