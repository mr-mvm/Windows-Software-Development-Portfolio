namespace SettingsPanelEnhanced
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSwitch toggleEnable;
        private MaterialSkin.Controls.MaterialSlider sliderVolume;
        private MaterialSkin.Controls.MaterialComboBox comboOptions;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnLoad;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialSwitch toggleTheme;
        private MaterialSkin.Controls.MaterialLabel lblTheme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.toggleEnable = new MaterialSkin.Controls.MaterialSwitch();
            this.sliderVolume = new MaterialSkin.Controls.MaterialSlider();
            this.comboOptions = new MaterialSkin.Controls.MaterialComboBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnLoad = new MaterialSkin.Controls.MaterialButton();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.toggleTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();

            this.SuspendLayout();

            // toggleEnable
            this.toggleEnable.AutoSize = true;
            this.toggleEnable.Depth = 0;
            this.toggleEnable.Location = new System.Drawing.Point(24, 90);
            this.toggleEnable.Text = "Enable Feature";
            this.toggleEnable.Checked = true;

            // sliderVolume
            this.sliderVolume.Depth = 0;
            this.sliderVolume.Location = new System.Drawing.Point(24, 140);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Minimum = 0;
            this.sliderVolume.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(300, 40);
            this.sliderVolume.Text = "Volume";

            // comboOptions
            this.comboOptions.AutoResize = false;
            this.comboOptions.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.comboOptions.Depth = 0;
            this.comboOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboOptions.DropDownHeight = 174;
            this.comboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOptions.DropDownWidth = 121;
            this.comboOptions.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.comboOptions.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.comboOptions.FormattingEnabled = true;
            this.comboOptions.Hint = "Select Option";
            this.comboOptions.IntegralHeight = false;
            this.comboOptions.ItemHeight = 43;
            this.comboOptions.Location = new System.Drawing.Point(24, 190);
            this.comboOptions.MaxDropDownItems = 4;
            this.comboOptions.MouseState = MaterialSkin.MouseState.OUT;
            this.comboOptions.Name = "comboOptions";
            this.comboOptions.Size = new System.Drawing.Size(300, 49);
            this.comboOptions.Items.AddRange(new object[] {
                "Option1",
                "Option2",
                "Option3"
            });

            // txtUsername
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular);
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(24, 250);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "";

            // toggleTheme
            this.toggleTheme.AutoSize = true;
            this.toggleTheme.Depth = 0;
            this.toggleTheme.Location = new System.Drawing.Point(24, 320);
            this.toggleTheme.Text = "Dark Theme";

            // btnSave
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(24, 360);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnLoad
            this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoad.Depth = 0;
            this.btnLoad.HighEmphasis = true;
            this.btnLoad.Icon = null;
            this.btnLoad.Location = new System.Drawing.Point(140, 360);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 36);
            this.btnLoad.Text = "Load";
            this.btnLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLoad.UseAccentColor = false;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // btnReset
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(260, 360);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.Text = "Reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(360, 420);
            this.Controls.Add(this.toggleEnable);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.comboOptions);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.toggleTheme);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReset);
            this.Name = "SettingsForm";
            this.Text = "Settings Panel - Enhanced";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
