using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public ViewResult PPolicy()
        {
            return View("PPolicy");
        }
    }
}
