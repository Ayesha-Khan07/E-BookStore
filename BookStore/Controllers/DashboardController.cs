
using _2ndBookStore;
using _2ndBookStore.Component;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class DashboardController : Controller
    {
        public ViewResult AdmDashboard()
        {
            return View();
        }

        public ViewResult AddUser()
        {
            return View("AddUser");
        }

        [HttpPost]
        public ViewResult Addus(string Email, string Password)
        {
            AdminRepo rep = new AdminRepo();
            bool ash = rep.add(Email, Password);
            
            if(ash == true)
            {
                return View("~/Views/Dashboard/AddUser.cshtml", "User Added Successfully");
            }
            else
            {
                return View("~/Views/Dashboard/AddUser.cshtml", "User Already Existed");
            }
        }


        public ViewResult DeleteUser()
        {
            return View("DeleteUser");
        }
        
        [HttpPost]
        public ViewResult Delete(string Email)
        {
            AdminRepo rep = new AdminRepo();
            bool del = rep.deleteUser(Email);
            if (del == true)
            {
                return View("~/Views/Dashboard/DeleteUser.cshtml", "User Deleted Successfully");
            }
            else
            {
                return View("~/Views/Dashboard/DeleteUser.cshtml", "User Does Not Exist");
            }
            
        }

        public ViewResult UpdateUser()
        {
            return View("UpdateUser");
        }

        [HttpPost]
        public ViewResult Updateus(string Email, string Password) 
        {
            AdminRepo rep = new AdminRepo();
            bool up = rep.update(Email, Password);

            if(up == true)
            {
                return View("~/Views/Dashboard/UpdateUser.cshtml", "User Updated Successfully");
            }

            else
            {
                return View("~/Views/Dashboard/UpdateUser.cshtml", "User Not Exist");
            }
        }

        public ViewResult ShowUsers()
        {
            /*  AdminRepo rep = new AdminRepo();
              List<Users> ulist = rep.getAllUsers();

              return View("~/Views/Dashboard/ShowUsers.cshtml", ulist);*/

            ViewUsers vu = new ViewUsers();
            List<Users> ulist = vu.Invoke();
            return View("~/Views/shared/Component/ViewUsers/Default.cshtml", ulist); 
            
        }

        public ViewResult AddBook()
        {
            return View("AddBook");
        }

        public ViewResult DeleteBook()
        {
            return View("DeleteBook");
        }
        public ViewResult UpdateCustomerProduct()
        {
            return View();
        }

        // public ViewResult DelBook(string ISBN)
        //{
        /*BookRepo rep = new BookRepo();
        bool del = rep.deleteBook(ISBN);
        if (del == true)
        {
            return View("~/Views/Dashboard/DeleteBook.cshtml", "Book Deleted Successfully");
        }
        else
        {
            return View("~/Views/Dashboard/DeleteBook.cshtml", "Book Does Not Exist");
        }
        */
    }

    /*  public ViewResult UpdateBook()
      {
          return View("UpdateBook");
      }
    public ActionResult updatingBook(string ISBN, string Title, string Author, int Price)
      {
          BookRepo repo = new BookRepo();
          bool updated = repo.updateBook(ISBN, Title, Author, Price);
          if (updated == true)
          {
              return View("~/Views/Admin/UpdateBook.cshtml", "Book Updated Successfully");
          }
          else
          {
              return View("~/Views/Admin/UpdateBook.cshtml", "Fail to Update Book");
          }
      }

    public ActionResult addingBook(string ISBN, string Title, string Author, int Price, IFormFile Image )
        {

            string path = "";
            path = Path.Combine(this.Environment.WebRootPath, "~/bookImages/try");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string FileName = Image.FileName;

            // combining GUID to create unique name before saving in wwwroot
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/try", FileName);
            string imgpath = "/images/try/" + FileName;
            // copying file
            FileStream n = new FileStream(imagePath, FileMode.Create);
            Image.CopyTo(n);
            n.Close();
            Book book = new Book();
            book.Isbn = ISBN;
            book.Title = Title;
            book.Author = Author;
            book.Price = Price;
            book.Image = imgpath;
            BookRepo repo = new BookRepo();
            bool added = repo.addBook(book);
            if (added == true)
            {
                return View("~/Views/Admin/AddBook.cshtml", "Book Added Successfully");
            }
            else
            {
                return View("~/Views/Admin/AddBook.cshtml", "Fail to Add Book");
            }
        }*/
}

