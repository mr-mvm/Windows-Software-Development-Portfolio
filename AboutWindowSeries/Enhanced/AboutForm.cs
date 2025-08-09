using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace AboutEnhanced
{
    public partial class AboutForm : MaterialForm
    {
        private AppConfig _cfg;

        public AboutForm()
        {
            InitializeComponent();
            var m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;

            _cfg = ConfigManager.Load();
            lblAppName.Text = _cfg.AppName;
            lblVersion.Text = $"Version {GetVersion()}";
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblActivated.Text = _cfg.Activated ? "Activated" : "Deactivated";
            lblExpiresOn.Text = _cfg.ExpiresOn?.ToLocalTime().ToString("dd-MMM-yyyy HH:mm") ?? "Never";
            btnDeactivate.Text = _cfg.Activated ? "Deactivate" : "Activate";
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(_cfg.Activated ? "Deactivate license?" : "Activate license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _cfg.Activated = !_cfg.Activated;
                if (!_cfg.Activated)
                {
                    _cfg.ExpiresOn = null;
                }
                ConfigManager.Save(_cfg);
                UpdateUI();
            }
        }

        private string GetVersion() => Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "1.0";
    }
}
