using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace _2ndBookStore.Component
{
    public class ViewUsers : ViewComponent
    {
        public List<Users> Invoke()
        {
            AdminRepo rep = new AdminRepo();
            List<Users> ulist = rep.getAllUsers();

            return ulist;
        }
        
    }
}
