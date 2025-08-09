using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace AboutSeries
{
    public abstract class BaseAboutForm : MaterialForm
    {
        protected Label lblAppName;
        protected Label lblVersion;
        protected Label lblDescription;
        protected MaterialButton btnOk;

        protected BaseAboutForm(string appName, string description)
        {
            InitializeMaterialSkin();
            InitializeCommonControls();

            lblAppName.Text = appName;
            lblVersion.Text = $"Version {GetVersion()}";
            lblDescription.Text = description;
        }

        private void InitializeMaterialSkin()
        {
            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeCommonControls()
        {
            lblAppName = new Label { Left = 20, Top = 20, AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 14) };
            lblVersion = new Label { Left = 20, Top = 60, AutoSize = true };
            lblDescription = new Label { Left = 20, Top = 90, Width = 300, AutoSize = true };
            btnOk = new MaterialButton { Text = "OK", Left = 20, Top = 150, Width = 100 };
            btnOk.Click += (s, e) => Close();

            Controls.Add(lblAppName);
            Controls.Add(lblVersion);
            Controls.Add(lblDescription);
            Controls.Add(btnOk);
        }

        protected virtual string GetVersion()
        {
            var v = Assembly.GetEntryAssembly()?.GetName().Version;
            return v?.ToString() ?? "1.0.0";
        }
    }
}
