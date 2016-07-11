using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Homework2.Tests
{
    [TestClass()]
    public class CalculatorBookTests
    {
        [TestMethod()]
        public void CalculatorPrinceTest_buy_1_book_should_be_100()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName="Potter1", Price=100 }
            };
            //act
            var actual = target.CalculatorPrice(books);
            //assert
            int expected = 100;
            Assert.AreEqual(expected, actual);
            
        }
    }
}