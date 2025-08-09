namespace AboutPro
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGitHubInfo;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGitHubInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 15);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version: --";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Pro Edition Description";
            // 
            // lblGitHubInfo
            // 
            this.lblGitHubInfo.AutoSize = true;
            this.lblGitHubInfo.Location = new System.Drawing.Point(12, 59);
            this.lblGitHubInfo.Name = "lblGitHubInfo";
            this.lblGitHubInfo.Size = new System.Drawing.Size(70, 15);
            this.lblGitHubInfo.TabIndex = 2;
            this.lblGitHubInfo.Text = "GitHub Info: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 130);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGitHubInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVersion);
            this.Name = "AboutForm";
            this.Text = "About - Pro Edition";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
