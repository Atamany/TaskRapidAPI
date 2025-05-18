using Microsoft.AspNetCore.Mvc;

namespace TaskRapidAPI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
