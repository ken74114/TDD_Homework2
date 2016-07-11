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
            return books.Sum(x => x.Price);
        }
    }
}
