using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterApp1.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void TestСalcDiscount_100and5_returned95()
        {
            //arrange
            double c = 100;
            double d = 5;
            double expected = 95;
            //act
            var actual = Calc.СalcDiscount(c, d);
            //assert
            Assert.AreEqual(expected, actual);
        }


        //[TestMethod]
        //public static T ThrowsException<T>(Func<object> action, string message, params object[] parameters) where T : Exception;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestСalcDiscount_minus5and5_returnedException()
        {
            double c = -5;
            double d = 5;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calc.СalcDiscount(c, d);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestСalcDiscount_100andminus5_returnedException()
        {
            double c = 100;
            double d = -5;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calc.СalcDiscount(c, d);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestСalcDiscount_100and105_returnedException()
        {
            double c = 100;
            double d = 105;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calc.СalcDiscount(c, d);
            });
        }
    }
}
