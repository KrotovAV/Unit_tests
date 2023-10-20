using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ConsoleApp4Tests
{
    [TestClass]
    public class IRepositoryTests
        //Здравствуйте, Леонид! Если Вы чтаете это сообщение, значит я здесь ещё разбираюсь с Mockами 
    {
        
        //Book b1 = new Book(){ Name = "b", Price = 100 };

        //Book[] books = {
                    //new Book(){Name="a", Price=100},
                    //new Book(){Name="d", Price=320},
                    //new Book(){Name="e", Price=56},
                    //};

        [TestMethod]
        public void IRepositoryTest()
        {
            

            //Mock<IRepository> mock = new Mock<IRepository>();
            //mock.Setup(r => r.GetBook(1)).Returns(books[0]);
            //mock.Setup(r => r.GetBook(It.Is<int>(v => v > 1))).Returns(books[2]);


            //// Шаг3. Тестируем mock объект
            //IRepository rep = mock.Object;
            //Book b0 = rep.GetBook(0); // null
            //Book b1 = rep.GetBook(1); // books[0]
            //Book b2 = rep.GetBook(2); // books[2]
            //Book b3 = rep.GetBook(3); // books[2]
            //Book b4 = rep.GetBook(4); // books[2]
            //Book b5 = rep.GetBook(5); // books[2]
        }
    }
}
