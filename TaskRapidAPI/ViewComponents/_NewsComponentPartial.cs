using Microsoft.AspNetCore.Mvc;
using TaskRapidAPI.Models;

namespace TaskRapidAPI.ViewComponents
{
    public class _NewsComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-news-data.p.rapidapi.com/topic-news-by-section?topic=TECHNOLOGY&section=CAQiSkNCQVNNUW9JTDIwdk1EZGpNWFlTQldWdUxVZENHZ0pKVENJT0NBUWFDZ29JTDIwdk1ETnliSFFxQ2hJSUwyMHZNRE55YkhRb0FBKi4IACoqCAoiJENCQVNGUW9JTDIwdk1EZGpNWFlTQldWdUxVZENHZ0pKVENnQVABUAE&limit=500&country=US&lang=en"),
                Headers =
    {
        { "x-rapidapi-key", "f3199434e5msh58ee98c4e68e750p14cb70jsn56545f8ecbb0" },
        { "x-rapidapi-host", "real-time-news-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<NewsViewModel>(body);
                if (model?.data != null && model.data.Any())
                {
                    model.data = model.data
                        .OrderByDescending(x => x.published_datetime_utc)
                        .Take(5)
                        .ToArray();
                }

                return View(model.data.ToList());
            }
        }
    }

}