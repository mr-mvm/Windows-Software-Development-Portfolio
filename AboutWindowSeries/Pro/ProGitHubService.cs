using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AboutPro
{
    public class GitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/")
            };
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("AboutProApp/1.0");
        }

        public async Task<string> GetLatestReleaseAsync(string owner, string repo)
        {
            var response = await _httpClient.GetAsync($"repos/{owner}/{repo}/releases/latest");
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();
            var json = await JsonDocument.ParseAsync(stream);

            if (json.RootElement.TryGetProperty("tag_name", out var tagName))
            {
                return tagName.GetString();
            }

            return "No release info found.";
        }
    }
}
