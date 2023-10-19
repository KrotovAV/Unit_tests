using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ConsoleApp4Tests
{
    [TestClass]
    public class UnitTest1
        //Здравствуйте, Леонид! Если Вы чтаете это сообщение, значит я здесь ещё разбираюсь с Mockами 
    {
        [TestMethod]
        public void TestMethod1()
        {

            Mock<IRepository> mock = new Mock<IRepository>();
            mock.Setup(r => r.GetBook(1)).Returns(books[0]);
            mock.Setup(r => r.GetBook(It.Is<int>(v => v > 1))).Returns(books[2]);
        }
    }
}
