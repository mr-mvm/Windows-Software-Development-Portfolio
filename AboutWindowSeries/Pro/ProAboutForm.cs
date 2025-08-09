using System;
using System.Windows.Forms;

namespace AboutPro
{
    public partial class AboutForm : Form
    {
        private readonly GitHubService _gitHubService;

        public AboutForm()
        {
            InitializeComponent();
            _gitHubService = new GitHubService();
        }

        private async void AboutForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = $"Version: {Application.ProductVersion}";
            lblDescription.Text = "Pro Edition - Includes GitHub integration";

            try
            {
                var repoInfo = await _gitHubService.GetLatestReleaseAsync("dotnet", "runtime");
                lblGitHubInfo.Text = $"Latest Release: {repoInfo}";
            }
            catch (Exception ex)
            {
                lblGitHubInfo.Text = $"Error: {ex.Message}";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
