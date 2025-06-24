using _2ndBookStore;

namespace BookStore.Models
{
    public class UserRepo
    {
        public void addUser(string Email , string Password)
        {
            Users user = new Users();
            user.Email = Email;
            user.Password = Password;

            StoreContext uc = new StoreContext();
            uc.Users.Add(user);
            uc.SaveChanges();
        }
        
        public bool checkEmailAlreadyExisted(string Email)
        {
            StoreContext uc = new StoreContext();
            var exist = uc.Users.Where(a => a.Email == Email);
            
            if(exist.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkUser(string Email , string Password)
        {
            StoreContext uc = new StoreContext();
            var exist = uc.Users.Where(a => a.Email == Email && a.Password == Password);

            if (exist.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
