using System.Net.Http;
using System.Net.Http.Headers;

namespace SandVpnApi
{
    public class SandVpn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.sandvpn.com";
        public SandVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetProxies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/proxys");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUnlock()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/unlock");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
