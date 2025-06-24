using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace BookStore.Controllers
{
    public class LoginController : Controller
    {
        public ViewResult Log()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(string Email , string Password) 
        {
            UserRepo rep = new UserRepo();

            bool ch = rep.checkUser(Email, Password);
            if(ch == true)
            {
                /*
                            cookie creation
                 HttpContext.Response.Cookies.Append("UserEmail", Email);
                */

                //session creation
                HttpContext.Session.SetString("UserEmail", Email);

                return RedirectToAction("Categ", "Login"); // Redirect to "Categ" action method
            }
            else 
            {
                return View("~/Views/Login/Log.cshtml", "Wrong Password or Email");
            }

        }

        public IActionResult CheckSession()
        {
            string semail = HttpContext.Session.GetString("UserEmail");
            if(string.IsNullOrEmpty(semail))
            {
                return Content("Session is not available.");
            }
            else
            {
                return Content("Session is available." + semail);
            }
        }

        public ViewResult Categ()
        {
            /*Get the cookie value from the request
            string email = HttpContext.Request.Cookies["UserEmail"];*/

            //get data from session
            string email = HttpContext.Session.GetString("UserEmail");

            return View("~/Views/Categories/Cat.cshtml", email);
        }


    }
}
