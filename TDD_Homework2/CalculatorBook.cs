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
            switch (books.Count)
            {
                case 2:
                    return Convert.ToInt32(books.Sum(x => x.Price) * 0.95);
                default:
                    return books.Sum(x => x.Price);
            }
        }
    }
}
