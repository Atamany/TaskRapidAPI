using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TaskRapidAPI.Models;

namespace TaskRapidAPI.ViewComponents
{
    public class _UsdTryComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=USD&to_symbol=TRY&language=en"),
                Headers =
    {
        { "x-rapidapi-key", "9b664cdc6dmsh2d94656c8bfbbd5p1e88a1jsnf5a1cbc7e3d3" },
        { "x-rapidapi-host", "real-time-finance-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var model = Newtonsoft.Json.JsonConvert.DeserializeObject<UsdTryViewModel>(body);
                return View(model);

            }
        }
    }
}
