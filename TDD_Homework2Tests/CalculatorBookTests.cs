﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod()]
        public void CalculatorPriceTest_buy_2_difference_book_should_be_190()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100},
                new Book {BookName="Potter2", Price=100  }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatorPriceTest_buy_3_difference_book_should_be_270()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100},
                new Book {BookName="Potter2", Price=100  },
                new Book {BookName="Potter3", Price=100  }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatorPriceTest_buy_4_difference_book_should_be_320()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100},
                new Book {BookName="Potter2", Price=100  },
                new Book {BookName="Potter3", Price=100  },
                new Book {BookName="Potter4", Price=100  }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatorPriceTest_buy_5_difference_book_should_be_375()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100},
                new Book {BookName="Potter2", Price=100  },
                new Book {BookName="Potter3", Price=100  },
                new Book {BookName="Potter4", Price=100  },
                new Book {BookName="Potter5", Price=100  }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatorPriceTest_buy_Potter1_volume1_and_Potter2_volume1_and_Potter3_volume2_should_be_370()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100 },
                new Book { BookName = "Potter2", Price=100 },
                new Book { BookName = "Potter3", Price=100 },
                new Book { BookName = "Potter3", Price=100 }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatorPriceTest_buy_Potter1_volume1_and_Potter2_volume2_and_Potter3_volume2_should_be_460()
        {
            //arrange
            var target = new CalculatorBook();
            var books = new List<Book>
            {
                new Book { BookName = "Potter1", Price=100 },
                new Book { BookName = "Potter2", Price=100 },
                new Book { BookName = "Potter2", Price=100 },
                new Book { BookName = "Potter3", Price=100 },
                new Book { BookName = "Potter3", Price=100 }
            };

            //act
            var actual = target.CalculatorPrice(books);

            //assert
            int expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}