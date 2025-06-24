using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AdminLoginController : Controller
    {
        public ViewResult AdmLog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdmLogin(string AdmEmail , string AdmPassword )
        {
            AdminRepo rep = new AdminRepo();
            
           // rep.addAdmin( AdmEmail , AdmPassword );

           
            bool ch = rep.checkAdmin(AdmEmail, AdmPassword);
             if (ch == true)
             {
                 HttpContext.Response.Cookies.Append("UserEmail", AdmEmail);
                 return RedirectToAction("Dash", "AdminLogin");

             }
             else
             {
                 return View("~/Views/AdminLogin/AdmLog.cshtml", "Wrong Password or Email");
             }

        }
        
        public ViewResult Dash()
        {
            // Get the cookie value from the request
            string email = HttpContext.Request.Cookies["UserEmail"];

            return View("~/Views/Dashboard/AdmDashboard.cshtml", email);
        }
    }
}

