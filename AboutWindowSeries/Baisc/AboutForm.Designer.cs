using System.ComponentModel;
using System.Windows.Forms;

namespace AboutBasic
{
    partial class AboutForm
    {
        private IContainer components = null;
        private MaterialSkin.Controls.MaterialLabel lblAppName;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialButton btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAppName = new MaterialSkin.Controls.MaterialLabel();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.btnOk = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // lblAppName
            this.lblAppName.AutoSize = true;
            this.lblAppName.Depth = 0;
            this.lblAppName.Font = new System.Drawing.Font("Roboto", 24F);
            this.lblAppName.Location = new System.Drawing.Point(24, 80);
            this.lblAppName.Text = "AppName";
            // lblVersion
            this.lblVersion.AutoSize = true;
            this.lblVersion.Depth = 0;
            this.lblVersion.Location = new System.Drawing.Point(24, 120);
            this.lblVersion.Text = "Version";
            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Location = new System.Drawing.Point(24, 150);
            this.lblDescription.Text = "Description";
            // btnOk
            this.btnOk.AutoSize = false;
            this.btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Location = new System.Drawing.Point(220, 200);
            this.btnOk.Size = new System.Drawing.Size(90, 36);
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // Form
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnOk);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
