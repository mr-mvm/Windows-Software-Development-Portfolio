namespace LicenseManagerEnhanced
{
    partial class LicenseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnStartTrial;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblCountdown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnStartTrial = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblPrompt
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 15);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(110, 15);
            this.lblPrompt.Text = "Enter License Key:";

            // txtLicenseKey
            this.txtLicenseKey.Location = new System.Drawing.Point(12, 35);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(260, 23);

            // btnActivate
            this.btnActivate.Location = new System.Drawing.Point(12, 70);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(80, 30);
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);

            // btnDeactivate
            this.btnDeactivate.Location = new System.Drawing.Point(102, 70);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(80, 30);
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);

            // btnStartTrial
            this.btnStartTrial.Location = new System.Drawing.Point(192, 70);
            this.btnStartTrial.Name = "btnStartTrial";
            this.btnStartTrial.Size = new System.Drawing.Size(80, 30);
            this.btnStartTrial.Text = "Start Trial";
            this.btnStartTrial.Click += new System.EventHandler(this.btnStartTrial_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 15);
            this.lblStatus.Text = "Status: Unknown";

            // lblCountdown
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(12, 135);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 15);

            // LicenseForm
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnStartTrial);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCountdown);
            this.Name = "LicenseForm";
            this.Text = "License Manager - Enhanced";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
