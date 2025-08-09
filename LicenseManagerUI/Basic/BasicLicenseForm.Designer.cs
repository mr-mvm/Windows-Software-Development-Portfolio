namespace LicenseManagerBasic
{
    partial class LicenseForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLicenseKey;
        private Button btnActivate;
        private Button btnDeactivate;
        private Label lblStatus;
        private Label lblPrompt;

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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
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
            this.btnActivate.Size = new System.Drawing.Size(120, 30);
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);

            // btnDeactivate
            this.btnDeactivate.Location = new System.Drawing.Point(152, 70);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(120, 30);
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 15);
            this.lblStatus.Text = "Status: Unknown";

            // LicenseForm
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.lblStatus);
            this.Name = "LicenseForm";
            this.Text = "License Manager - Basic";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
