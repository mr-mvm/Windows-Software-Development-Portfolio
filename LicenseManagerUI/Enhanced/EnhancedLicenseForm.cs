using System;
using System.Windows.Forms;
using System.Timers;

namespace LicenseManagerEnhanced
{
    public partial class LicenseForm : Form
    {
        private LicenseManager licenseManager;
        private System.Timers.Timer countdownTimer;

        public LicenseForm()
        {
            InitializeComponent();
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

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (licenseManager.IsActive)
            {
                MessageBox.Show("License is already active.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string key = txtLicenseKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a license key.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulate activation with expiry 30 days from now
            licenseManager.Activate(key, DateTime.Now.AddDays(30));
            UpdateUI();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            licenseManager.Deactivate();
            UpdateUI();
        }

        private void btnStartTrial_Click(object sender, EventArgs e)
        {
            if (licenseManager.IsActive || licenseManager.IsTrial)
            {
                MessageBox.Show("Already activated or in trial.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Start a 7-day trial
            licenseManager.StartTrial(DateTime.Now.AddDays(7));
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblStatus.Text = licenseManager.IsActive ? $"Status: Active (Expires {licenseManager.ExpiryDate?.ToShortDateString()})" :
                               licenseManager.IsTrial ? $"Status: Trial (Ends {licenseManager.TrialExpiryDate.ToShortDateString()})" :
                               "Status: Inactive";

            btnActivate.Enabled = !licenseManager.IsActive;
            btnStartTrial.Enabled = !licenseManager.IsActive && !licenseManager.IsTrial;
        }
    }
}
