using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Homework2
{
    public class CalculatorBook
    {
        public int CalculatorPrice(List<Book> books)
        {
            var differenceBooks = books.Distinct(new BookCompare()).ToList();

            switch (differenceBooks.Count)
            {
                case 2:
                    return Convert.ToInt32(differenceBooks.Sum(x => x.Price) * 0.95);
                case 3:
                    return Convert.ToInt32(differenceBooks.Sum(x => x.Price) * 0.9);
                case 4:
                    return Convert.ToInt32(differenceBooks.Sum(x => x.Price) * 0.8);
                default:
                    return books.Sum(x => x.Price);
            }
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
