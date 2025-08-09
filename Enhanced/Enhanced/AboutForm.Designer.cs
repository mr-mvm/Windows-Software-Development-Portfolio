namespace AboutEnhanced
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblInfo;
        private TextBox txtInfo;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(102, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Saved Information";

            // txtInfo
            this.txtInfo.Location = new System.Drawing.Point(12, 50);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(260, 100);
            this.txtInfo.TabIndex = 1;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(12, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // AboutForm
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblInfo);
            this.Name = "AboutForm";
            this.Text = "About - Enhanced";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

