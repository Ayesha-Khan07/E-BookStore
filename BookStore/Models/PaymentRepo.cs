using _2ndBookStore;

namespace BookStore.Models
{
    public class PaymentRepo
    {
        public void addCashOnDeliveryDetails(string UserName, string Address, string ContactNum)
        {
            Cash cas = new Cash();
            cas.UserName = UserName;
            cas.Address = Address;
            cas.ContactNum = ContactNum;

            StoreContext uc = new StoreContext();
            uc.Cashes.Add(cas);
            uc.SaveChanges();
        }

        public void addOnlinePaymentDetails(string UserName, string Address, string ContactNum, string CreditCardNum)
        {
            OnlinePay onpay = new OnlinePay();
            onpay.UserName = UserName;
            onpay.Address = Address;
            onpay.ContactNum = ContactNum;
            onpay.CreditCardNum = CreditCardNum;

            StoreContext uc = new StoreContext();
            uc.OnlinePays.Add(onpay);
            uc.SaveChanges();
        }
    }
}
