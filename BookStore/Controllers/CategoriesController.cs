using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public ViewResult Cat()
        {
            return View();
        }

    }
}
