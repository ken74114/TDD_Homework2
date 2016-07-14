using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Homework2
{
    public class CalculatorBook
    {
        private Dictionary<int, double> Discount
        {
            get
            {
                Dictionary<int, double> discount = new Dictionary<int, double>();
                discount.Add(1, 1);
                discount.Add(2, 0.95);
                discount.Add(3, 0.9);
                discount.Add(4, 0.8);
                discount.Add(5, 0.75);
                return discount;
            }
        }

        public int CalculatorPrice(List<Book> books)
        {
            int total = 0;
            var allBooks = books.Select(x => x.Clone()).ToList();

            var differenceBooks = GetBookSuite(allBooks);

            RemoveBookSuite(differenceBooks, allBooks);

            if (allBooks.Count > 0)
            {
                total += this.CalculatorPrice(allBooks);
            }
            return total += CalculateAmount(differenceBooks);
        }

        private List<Book> GetBookSuite(List<Book> books)
        {
            return books.Distinct(new BookCompare()).ToList();
        }

        private void RemoveBookSuite(List<Book> differenceBooks, List<Book> books)
        {
            differenceBooks.ForEach(x => books.Remove(x));
        }

        private int CalculateAmount(List<Book> books)
        {
            return Convert.ToInt32(books.Sum(x => x.Price) * Discount[books.Count()]);
        }
    }

    public class BookCompare : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            return x.BookName.Equals(y.BookName);
        }

        public int GetHashCode(Book obj)
        {
            return obj.BookName.GetHashCode();
        }
    }
}