namespace BookStore.Models
{
    public class BookRepo
    {
        /* public bool addBook(Book book)
        {
            BookStoreContext cx = new BookStoreContext();
            cx.Books.Add(book);
            cx.SaveChanges();
            var added = cx.Books.Find(book.Isbn);
            if (added != null)
            {
                return true;
            }
            else
                return false;
        }
         public bool deleteBook(string ISBN)
         {
             UsersContext uc = new UsersContext();
             var book = uc.Books.Find(ISBN);
             if (book != null)
             {
                 uc.Books.Remove(book);
                 uc.SaveChanges();
                 return true;
             }
             else
             {
                 return false;
             }
         }

        public bool updateBook(string ISBN, string Title, string Author, int Price)
         {
             BookStoreContext cx = new BookStoreContext();
             var book = cx.Books.Find(ISBN);
             if (book != null)
             {
                 book.Title = Title;
                 book.Author = Author;
                 book.Price = Price;
                 cx.SaveChanges();
                 return true;
             }
             else
             {
                 return false;
             }
         }*/
    }
}
