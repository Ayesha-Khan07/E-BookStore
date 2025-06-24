using Microsoft.AspNetCore.Components.Web;
using _2ndBookStore;

namespace BookStore.Models
{
    public class AdminRepo
    {
        public void addAdmin(string AdmEmail, string AdmPassword)
        {
            StoreAdmin adm = new StoreAdmin();
            adm.AdmEmail = AdmEmail;
            adm.AdmPassword = AdmPassword;

            StoreContext uc = new StoreContext();
            uc.StoreAdmins.Add(adm);
            uc.SaveChanges();
        }

        public bool checkAdmin(string AdmEmail, string AdmPassword)
        {
            StoreContext uc = new StoreContext();
            var exist = uc.StoreAdmins.Where(a => a.AdmEmail == AdmEmail && a.AdmPassword == AdmPassword);

            if (exist.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool deleteUser(string Email)
        {
            StoreContext uc = new StoreContext();
            var exist = uc.Users.Where(a => a.Email == Email);

            if (exist.Count() == 0)
            {
                return false;
            }
            else
            {
                Users user = new Users();
                user.Email = Email;

                uc.Users.Remove(user);
                uc.SaveChanges();
                return true;
            }
        }

        public bool add(string Email, string Password)
        {
            StoreContext uc = new StoreContext();
            UserRepo urep = new UserRepo();

            bool temp = urep.checkUser(Email, Password);
            if (temp == false)
            {
                Users user = new Users();
                user.Email = Email;
                user.Password = Password;

                uc.Users.Add(user);
                uc.SaveChanges();
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool update(string Email, string Password)
        {
            StoreContext uc = new StoreContext();
            UserRepo urep = new UserRepo();
            var exist = urep.checkEmailAlreadyExisted(Email);

            if(exist == false)
            {
                Users us = new Users();
                us.Email = Email;
                us.Password = Password;
                uc.Users.Update(us);
                uc.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Users> getAllUsers()
        {
            List<Users> ulist = new List<Users>();
            Users us = new Users();

            StoreContext uc = new StoreContext();
            IQueryable users = uc.Users;

            foreach (Users u in users)
            {
                ulist.Add(u);
            }

            return ulist;
        }
    }
}
