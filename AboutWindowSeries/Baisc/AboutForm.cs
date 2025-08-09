using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace AboutBasic
{
    public partial class AboutForm : MaterialForm
    {
        public AboutForm()
        {
            InitializeComponent();

            // MaterialSkin manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            lblAppName.Text = "MyApp";
            lblVersion.Text = $"Version {GetVersion()}";
            lblDescription.Text = "A small demo About window for portfolio.";
        }

        private string GetVersion()
        {
            var v = Assembly.GetEntryAssembly()?.GetName().Version;
            return v?.ToString() ?? "1.0.0";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
