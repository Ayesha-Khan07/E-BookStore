using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult logout()
        {
            /*
             * delete cookie
            Response.Cookies.Delete("Email");
            */

            //delete session
            HttpContext.Session.Remove("UserEmail");

            //now redirect to home page
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
