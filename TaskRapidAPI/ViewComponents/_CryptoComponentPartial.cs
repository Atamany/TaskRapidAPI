using Microsoft.AspNetCore.Mvc;
using TaskRapidAPI.Models;

namespace TaskRapidAPI.ViewComponents
{
    public class _CryptoComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://crypto-market-prices.p.rapidapi.com/tokens?base=USDT"),
                Headers =
    {
        { "x-rapidapi-key", "f3199434e5msh58ee98c4e68e750p14cb70jsn56545f8ecbb0" },
        { "x-rapidapi-host", "crypto-market-prices.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<CryptoViewModel>(body);
                return View(model);

            }
        }
    }
}