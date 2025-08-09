namespace SettingsPanelPro
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialComboBox comboCategory;
        private MaterialSkin.Controls.MaterialTextBox txtKey;
        private MaterialSkin.Controls.MaterialTextBox txtValue;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnLoad;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton btnSync;
        private MaterialSkin.Controls.MaterialSwitch toggleTheme;
        private MaterialSkin.Controls.MaterialLabel lblCategory;
        private MaterialSkin.Controls.MaterialLabel lblKey;
        private MaterialSkin.Controls.MaterialLabel lblValue;
        private MaterialSkin.Controls.MaterialLabel lblTheme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.txtKey = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValue = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnLoad = new MaterialSkin.Controls.MaterialButton();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnSync = new MaterialSkin.Controls.MaterialButton();
            this.toggleTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.lblCategory = new MaterialSkin.Controls.MaterialLabel();
            this.lblKey = new MaterialSkin.Controls.MaterialLabel();
            this.lblValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();

            this.SuspendLayout();

            // comboCategory
            this.comboCategory.AutoResize = false;
            this.comboCategory.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.comboCategory.Depth = 0;
            this.comboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCategory.DropDownHeight = 174;
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.DropDownWidth = 121;
            this.comboCategory.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.comboCategory.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.IntegralHeight = false;
            this.comboCategory.ItemHeight = 43;
            this.comboCategory.Location = new System.Drawing.Point(24, 100);
            this.comboCategory.MaxDropDownItems = 4;
            this.comboCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(300, 49);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Depth = 0;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular);
            this.lblCategory.Location = new System.Drawing.Point(24, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 19);
            this.lblCategory.Text = "Category";

            // txtKey
            this.txtKey.AnimateReadOnly = false;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Depth = 0;
            this.txtKey.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular);
            this.txtKey.Hint = "Setting Key";
            this.txtKey.LeadingIcon = null;
            this.txtKey.Location = new System.Drawing.Point(24, 170);
            this.txtKey.MaxLength = 50;
            this.txtKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKey.Multiline = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(300, 50);
            this.txtKey.TabIndex = 0;
            this.txtKey.Text = "";

            // lblKey
            this.lblKey.AutoSize = true;
            this.lblKey.Depth = 0;
            this.lblKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular);
            this.lblKey.Location = new System.Drawing.Point(24, 140);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(92, 19);
            this.lblKey.Text = "Setting Key";

            // txtValue
            this.txtValue.AnimateReadOnly = false;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue.Depth = 0;
            this.txtValue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular);
            this.txtValue.Hint = "Setting Value";
            this.txtValue.LeadingIcon = null;
            this.txtValue.Location = new System.Drawing.Point(24, 250);
            this.txtValue.MaxLength = 100;
            this.txtValue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(300, 50);
            this.txtValue.TabIndex = 1;
            this.txtValue.Text = "";

            // lblValue
            this.lblValue.AutoSize = true;
            this.lblValue.Depth = 0;
            this.lblValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular);
            this.lblValue.Location = new System.Drawing.Point(24, 220);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(98, 19);
            this.lblValue.Text = "Setting Value";

            // toggleTheme
            this.toggleTheme.AutoSize = true;
            this.toggleTheme.Depth = 0;
            this.toggleTheme.Location = new System.Drawing.Point(24, 320);
            this.toggleTheme.Text = "Dark Theme";

            // lblTheme
            this.lblTheme.AutoSize = true;
            this.lblTheme.Depth = 0;
            this.lblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular);
            this.lblTheme.Location = new System.Drawing.Point(24, 290);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(53, 19);
            this.lblTheme.Text = "Theme";

            // btnSave
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Location = new System.Drawing.Point(24, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseVisualStyleBackColor = true;

            // btnLoad
            this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoad.Depth = 0;
            this.btnLoad.HighEmphasis = true;
            this.btnLoad.Location = new System.Drawing.Point(140, 370);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 36);
            this.btnLoad.Text = "Load";
            this.btnLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLoad.UseVisualStyleBackColor = true;

            // btnReset
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Location = new System.Drawing.Point(260, 370);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.Text = "Reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReset.UseVisualStyleBackColor = true;

            // btnSync
            this.btnSync.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSync.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSync.Depth = 0;
            this.btnSync.HighEmphasis = true;
            this.btnSync.Location = new System.Drawing.Point(24, 420);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSync.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(336, 36);
            this.btnSync.Text = "Sync Settings to Cloud (Simulated)";
            this.btnSync.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSync.UseVisualStyleBackColor = true;

            // Form
            this.ClientSize = new System.Drawing.Size(384, 480);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.toggleTheme);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSync);
            this.Name = "SettingsForm";
            this.Text = "Settings Panel - Pro";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
