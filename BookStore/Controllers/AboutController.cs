using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AboutController : Controller
    {
        public ViewResult AboutUs()
        {
            return View();
        }

    }
}
