using System;
namespace bookstore.Models.ViewModels
{
    public class PageInfo
    {

        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        // calc how many pages you need for each instance
        public int TotalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
