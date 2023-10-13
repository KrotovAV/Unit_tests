using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp3Tests
{
    [TestClass]
    public class InIntervalTests
    {  
        [TestMethod]
        public void TestNumberInInterval_2In5And15_returnedFalse()
        {
            int validNamber = 2;
            int validLeftBorder = 5;
            int validRightBorder = 15;
            var expected = InInterval.NumberInInterval(validNamber, validLeftBorder, validRightBorder);
            Assert.IsFalse(expected);
        }
        [TestMethod]
        public void TestNumberInInterval_5In5And15_returnedTrue()
        {
            int validNamber = 5;
            int validLeftBorder = 5;
            int validRightBorder = 15;
            var expected = InInterval.NumberInInterval(validNamber, validLeftBorder, validRightBorder);
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestNumberInInterval_10In5And15_returnedTrue()
        {
            int validNamber = 10;
            int validLeftBorder = 5;
            int validRightBorder = 15;
            var expected = InInterval.NumberInInterval(validNamber, validLeftBorder, validRightBorder);
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestNumberInInterval_15In5And15_returnedTrue()
        {
            int validNamber = 2;
            int validLeftBorder = 5;
            int validRightBorder = 15;
            var expected = InInterval.NumberInInterval(validNamber, validLeftBorder, validRightBorder);
            Assert.IsTrue(expected);
        }


        [TestMethod]
        public void TestNumberInInterval_20In5And15_returnedFalse()
        {
            int validNamber = 20;
            int validLeftBorder = 5;
            int validRightBorder = 15;
            var expected = InInterval.NumberInInterval(validNamber, validLeftBorder, validRightBorder);
            Assert.IsFalse(expected);
        }

        private void AssertThrowsException(int namber, int leftBorder, int rightBorder)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                InInterval.NumberInInterval(namber, leftBorder, rightBorder);
            });
            InInterval.NumberInInterval(namber, leftBorder, rightBorder);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNumberInInterval_5In15And5_returnedException()
        {
            int validNamber = 5;
            int invalidLeftBorder = 15;
            int invalidRightBorder = 5;
            AssertThrowsException(validNamber, invalidLeftBorder, invalidRightBorder);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNumberInInterval_5In10And10_returnedException()
        {
            int validNamber = 2;
            int invalidLeftBorder = 10;
            int invalidRightBorder = 10;
            AssertThrowsException(validNamber, invalidLeftBorder, invalidRightBorder);
        }



    }
}
