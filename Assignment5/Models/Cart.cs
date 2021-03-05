using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Cart
    {
        // Make a list of line items
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        // Add a single line item to the cart
        public virtual void AddItem (Book book, int quantity)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        // Remove a single line item from cart
        public virtual void RemoveItem(Book book) =>
            Lines.RemoveAll(x => x.Book.BookID == book.BookID);

        // Remove all Items from cart
        public virtual void Clear() => Lines.Clear();

        // Add up the cost of all books in cart
        public decimal ComputeTotalSum() => Lines.Sum(e => (decimal)e.Book.Price * e.Quantity);

        // Constructor to identify what a cart line item contains.
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
