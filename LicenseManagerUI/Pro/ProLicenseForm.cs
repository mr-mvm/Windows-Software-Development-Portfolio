using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace LicenseManagerPro
{
    public partial class LicenseForm : MaterialForm
    {
        private LicenseManager licenseManager;
        private System.Timers.Timer countdownTimer;
        private MaterialSkinManager materialSkinManager;

        public LicenseForm()
        {
            InitializeComponent();

            // Setup MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            licenseManager = new LicenseManager("license.json");
            InitializeCountdownTimer();
            UpdateUI();
        }

        private void InitializeCountdownTimer()
        {
            countdownTimer = new System.Timers.Timer(1000);
            countdownTimer.Elapsed += CountdownTimer_Elapsed;
            countdownTimer.Start();
        }

        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (licenseManager.IsActive && licenseManager.ExpiryDate.HasValue)
            {
                var remaining = licenseManager.ExpiryDate.Value - DateTime.Now;
                if (remaining <= TimeSpan.Zero)
                {
                    licenseManager.Deactivate();
                    Invoke(new Action(UpdateUI));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        lblCountdown.Text = $"Expires in: {remaining.Days}d {remaining.Hours}h {remaining.Minutes}m {remaining.Seconds}s";
                    }));
                }
            }
            else if (licenseManager.IsTrial)
            {
                var remainingTrial = licenseManager.TrialExpiryDate - DateTime.Now;
                if (remainingTrial <= TimeSpan.Zero)
                {
                    licenseManager.Deactivate();
                    Invoke(new Action(UpdateUI));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        lblCountdown.Text = $"Trial Mode: {remainingTrial.Days}d {remainingTrial.Hours}h {remainingTrial.Minutes}m {remainingTrial.Seconds}s left";
                    }));
                }
            }
            else
            {
                Invoke(new Action(() => lblCountdown.Text = ""));
            }
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            if (licenseManager.IsActive)
            {
                using (var md = new MaterialDialog(this)
                {
                    Text = "Already Active",
                    Message = "License is already active.",
                    Buttons = new[] { "OK" }
                })
                {
                    await md.ShowAsync();
                }
                return;
            }

            string key = txtLicenseKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                using (var md = new MaterialDialog(this)
                {
                    Text = "Input Required",
                    Message = "Please enter a license key.",
                    Buttons = new[] { "OK" }
                })
                {
                    await md.ShowAsync();
                }
                return;
            }

            using (var mdConfirm = new MaterialDialog(this)
            {
                Text = "Activate License",
                Message = "Are you sure you want to activate the license?",
                Buttons = new[] { "Yes", "No" },
                DefaultButtonIndex = 1,
                CancelButtonIndex = 1
            })
            {
                var result = await mdConfirm.ShowAsync();
                if (result == MaterialDialog.Result.FirstButton) // "Yes"
                {
                    licenseManager.Activate(key, DateTime.Now.AddDays(30));
                    UpdateUI();
                }
            }
        }

        private async void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (!licenseManager.IsActive && !licenseManager.IsTrial)
            {
                using (var md = new MaterialDialog(this)
                {
                    Text = "Not Active",
                    Message = "No active license or trial to deactivate.",
                    Buttons = new[] { "OK" }
                })
                {
                    await md.ShowAsync();
                }
                return;
            }

            using (var mdConfirm = new MaterialDialog(this)
            {
                Text = "Deactivate License",
                Message = "Are you sure you want to deactivate the license?",
                Buttons = new[] { "Yes", "No" },
                DefaultButtonIndex = 1,
                CancelButtonIndex = 1
            })
            {
                var result = await mdConfirm.ShowAsync();
                if (result == MaterialDialog.Result.FirstButton) // "Yes"
                {
                    licenseManager.Deactivate();
                    UpdateUI();
                }
            }
        }

        private async void btnStartTrial_Click(object sender, EventArgs e)
        {
            if (licenseManager.IsActive || licenseManager.IsTrial)
            {
                using (var md = new MaterialDialog(this)
                {
                    Text = "Trial Not Allowed",
                    Message = "Already activated or in trial.",
                    Buttons = new[] { "OK" }
                })
                {
                    await md.ShowAsync();
                }
                return;
            }

            using (var mdConfirm = new MaterialDialog(this)
            {
                Text = "Start Trial",
                Message = "Start a 7-day trial?",
                Buttons = new[] { "Yes", "No" },
                DefaultButtonIndex = 1,
                CancelButtonIndex = 1
            })
            {
                var result = await mdConfirm.ShowAsync();
                if (result == MaterialDialog.Result.FirstButton)
                {
                    licenseManager.StartTrial(DateTime.Now.AddDays(7));
                    UpdateUI();
                }
            }
        }

        private void UpdateUI()
        {
            lblStatus.Text = licenseManager.IsActive
                ? $"Status: Active (Expires {licenseManager.ExpiryDate?.ToShortDateString()})"
                : licenseManager.IsTrial
                    ? $"Status: Trial (Ends {licenseManager.TrialExpiryDate.ToShortDateString()})"
                    : "Status: Inactive";

            // Visual status indicator - icon + color
            if (licenseManager.IsActive)
            {
                picStatusIcon.Image = Properties.Resources.active_icon; // Add your active icon to Resources
                lblStatus.ForeColor = Color.Green;
            }
            else if (licenseManager.IsTrial)
            {
                picStatusIcon.Image = Properties.Resources.trial_icon; // Add your trial icon to Resources
                lblStatus.ForeColor = Color.Orange;
            }
            else
            {
                picStatusIcon.Image = Properties.Resources.inactive_icon; // Add your inactive icon to Resources
                lblStatus.ForeColor = Color.Red;
            }

            btnActivate.Enabled = !licenseManager.IsActive;
            btnStartTrial.Enabled = !licenseManager.IsActive && !licenseManager.IsTrial;
        }
    }
}
