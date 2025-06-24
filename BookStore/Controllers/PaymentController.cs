using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class PaymentController : Controller
	{
		public IActionResult PaymentMethod()
		{
			return View();
		}

        public IActionResult CashOnDelivery()
        {
            return View();
        }

        public IActionResult Cash(string UserName , string Address, string ContactNum)
        {
            PaymentRepo pay = new PaymentRepo();
            pay.addCashOnDeliveryDetails(UserName, Address, ContactNum);
            return View("~/Views/Payment/CashOnDelivery.cshtml", "Your Data Is Recorded. Thank You:)");
        }

        public IActionResult OnlinePayment()
        {
            return View();
        }

        public IActionResult PayOnline(string UserName, string Address, string ContactNum , string CreditCardNum)
        {
            PaymentRepo pay = new PaymentRepo();
            pay.addOnlinePaymentDetails(UserName, Address, ContactNum, CreditCardNum);

            return View("~/Views/Payment/OnlinePayment.cshtml", "Your Data Is Recorded. Thank You:)");
        }
    }
}
