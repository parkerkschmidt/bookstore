using System;
using System.Collections.Generic;
using System.Linq;


// model to add books to basket/cart

namespace bookstore.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem(Book book, int qty)
        {
            BasketLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty,
                    Price = book.Price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        // function to calc total to display on page
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Price);

            return sum;
        }
    }

    public class BasketLineItem
    {
        public int LindID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
