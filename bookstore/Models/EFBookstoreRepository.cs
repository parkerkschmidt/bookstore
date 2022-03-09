using System;
using System.Linq;

namespace bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;


        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void AddBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();

        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
