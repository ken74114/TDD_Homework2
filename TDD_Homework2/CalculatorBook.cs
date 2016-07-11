using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Homework2
{
    public class CalculatorBook
    {
        private double[] distinct = new double[] { 1, 0.95, 0.9, 0.8, 0.75 };

        public int CalculatorPrice(List<Book> books)
        {
            int total = 0;
            var differenceBooks = books.Distinct(new BookCompare()).ToList();
            differenceBooks.Select(x => books.Remove(x)).ToList();
            if (books.Count > 0)
            {
                total += this.CalculatorPrice(books);
            }
            return total += Convert.ToInt32(differenceBooks.Sum(x => x.Price) * distinct[differenceBooks.Count - 1]);
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