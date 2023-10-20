using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Tests
{
    [TestClass]
    public class BookServiceTests
    {
        List<Book> books = new List<Book> {
            new Book("001", "Aaaaaa", "Aaaa A"),
            new Book("002", "Bbbbbb", "Bbbb B"),
            new Book("003", "Cccccc", "Cccc C"),
            new Book("004", "Dddddd", "Dddd d") };

        [TestMethod]
        public void findBookByIdTest_ShouldReturnBook()
        {
            Mock<BookService> mock = new Mock<BookService>();
            mock.Setup(r => r.findBookById("001")).Returns(books[0]);
         
            BookService rep = mock.Object;
            var actual = rep.findBookById("001");

            Book expected = books[0];
            Assert.AreEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(Book));  

        }


        //[TestMethod]
        //public void findAlTest_ShouldReturnListBooks()
        //{
        //    Mock<BookService> mock = new Mock<BookService>();
        //    mock.Setup(r => r.findAl()).Returns(books);

        //    BookService rep = mock.Object;
        //    var actual = rep.findAl();

        //    List<Book> expected = books;
        //    Assert.AreEqual(expected, actual);

        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void findBookByIdTest_no_book_Return_non_existence()
        //{
        //    Mock<BookService> mock = new Mock<BookService>();
        //    mock.Setup(r => r.List()).Returns((List<Book>)null);

        //    BookService rep = mock.Object;
        //    var actual = rep.findBookById("005");

        //    Assert.ThrowsException<ThereIsNoBookException>(() => r.List());
        //}



    }
}
