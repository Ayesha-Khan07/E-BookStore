using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Hm()
        {
            return View();
        }
        public ViewResult Notification()
        {
            return View();
        }

    }
}
