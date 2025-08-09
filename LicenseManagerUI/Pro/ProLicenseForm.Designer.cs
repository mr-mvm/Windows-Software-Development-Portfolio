namespace LicenseManagerPro
{
    partial class LicenseForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox txtLicenseKey;
        private MaterialSkin.Controls.MaterialButton btnActivate;
        private MaterialSkin.Controls.MaterialButton btnDeactivate;
        private MaterialSkin.Controls.MaterialButton btnStartTrial;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel lblCountdown;
        private System.Windows.Forms.PictureBox picStatusIcon;
        private MaterialSkin.Controls.MaterialLabel lblPrompt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLicenseKey = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActivate = new MaterialSkin.Controls.MaterialButton();
            this.btnDeactivate = new MaterialSkin.Controls.MaterialButton();
            this.btnStartTrial = new MaterialSkin.Controls.MaterialButton();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblCountdown = new MaterialSkin.Controls.MaterialLabel();
            this.picStatusIcon = new System.Windows.Forms.PictureBox();
            this.lblPrompt = new MaterialSkin.Controls.MaterialLabel();

            ((System.ComponentModel.ISupportInitialize)(this.picStatusIcon)).BeginInit();
            this.SuspendLayout();

            // lblPrompt
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Depth = 0;
            this.lblPrompt.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblPrompt.Location = new System.Drawing.Point(12, 80);
            this.lblPrompt.Text = "Enter License Key:";

            // txtLicenseKey
            this.txtLicenseKey.Location = new System.Drawing.Point(12, 110);
            this.txtLicenseKey.Size = new System.Drawing.Size(300, 48);
            this.txtLicenseKey.Hint = "License key";
            this.txtLicenseKey.LeadingIcon = null;

            // btnActivate
            this.btnActivate.Location = new System.Drawing.Point(12, 170);
            this.btnActivate.Size = new System.Drawing.Size(90, 36);
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);

            // btnDeactivate
            this.btnDeactivate.Location = new System.Drawing.Point(120, 170);
            this.btnDeactivate.Size = new System.Drawing.Size(90, 36);
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);

            // btnStartTrial
            this.btnStartTrial.Location = new System.Drawing.Point(228, 170);
            this.btnStartTrial.Size = new System.Drawing.Size(90, 36);
            this.btnStartTrial.Text = "Start Trial";
            this.btnStartTrial.Click += new System.EventHandler(this.btnStartTrial_Click);

            // lblStatus
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblStatus.Location = new System.Drawing.Point(12, 220);
            this.lblStatus.Size = new System.Drawing.Size(300, 25);
            this.lblStatus.Text = "Status: Unknown";

            // lblCountdown
            this.lblCountdown.Depth = 0;
            this.lblCountdown.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblCountdown.Location = new System.Drawing.Point(12, 250);
            this.lblCountdown.Size = new System.Drawing.Size(300, 22);
            this.lblCountdown.Text = "";

            // picStatusIcon
            this.picStatusIcon.Location = new System.Drawing.Point(320, 220);
            this.picStatusIcon.Size = new System.Drawing.Size(32, 32);
            this.picStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // LicenseForm
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnStartTrial);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.picStatusIcon);
            this.Name = "LicenseForm";
            this.Text = "License Manager - Pro";

            ((System.ComponentModel.ISupportInitialize)(this.picStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
