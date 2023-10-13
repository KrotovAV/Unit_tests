using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp3Tests
{
    [TestClass]
    public class OddNamberTests
    {
        [TestMethod]
        public void TestOddNamber_10_returnedTrue()
        {
            //arrange
            int oddNamber = 10;
            //act
            var expected = OddNamber.EvenOddNumber(oddNamber);
            //assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestOddNamber_15_returnedFalse()
        {
            //arrange
            int notOddNamber = 15;
            //act
            var expected = OddNamber.EvenOddNumber(notOddNamber);
            //assert
            Assert.IsFalse(expected);
        }

    }
}
