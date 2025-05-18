using Microsoft.AspNetCore.Mvc;
using TaskRapidAPI.Models;

namespace TaskRapidAPI.ViewComponents
{
    public class _SoccerComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://free-api-live-football-data.p.rapidapi.com/football-current-live"),
                Headers =
    {
        { "x-rapidapi-key", "9b664cdc6dmsh2d94656c8bfbbd5p1e88a1jsnf5a1cbc7e3d3" },
        { "x-rapidapi-host", "free-api-live-football-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var model = Newtonsoft.Json.JsonConvert.DeserializeObject<SoccerViewModel>(body);
                return View(model);
            }
        }
    }
}
