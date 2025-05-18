using Microsoft.AspNetCore.Mvc;
using TaskRapidAPI.Models;

namespace TaskRapidAPI.ViewComponents
{
    public class _FuelComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
                Headers =
    {
        { "x-rapidapi-key", "bc0fdeb878msh2213987e8ca48cbp17bc42jsnb80972c524ff" },
        { "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<FuelViewModel>(body);
                return View(model);

            }
        }
    }
}
