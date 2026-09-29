using Microsoft.AspNetCore.Mvc;

namespace WeekendCheck.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
