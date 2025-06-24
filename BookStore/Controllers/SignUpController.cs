using BookStore.Models;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class SignUpController : Controller
    {
        public ViewResult Sign()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Registration(string Email , string Password)
        {
            if(Email == null || Password == null)
            {
                return View("~/Views/SignUp/Sign.cshtml", "Enter Email and Password");
            }

            UserRepo rep = new UserRepo();
            rep.addUser(Email, Password);

            return View("~/Views/Categories/Cat.cshtml");
        }
    }
}
