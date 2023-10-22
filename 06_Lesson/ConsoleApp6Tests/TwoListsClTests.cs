using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Runtime.ConstrainedExecution;
using ConsoleApp6;

namespace ConsoleApp6Tests
{
    [TestClass]
    public class TwoListsClTests
    {
        List<int> Lst00 = new List<int>() { };
        //double avg00 = 0;
        List<int> Lst000 = new List<int>() { };
        //double avg000 = 0;
        List<int> Lst01 = new List<int>() { 1 };
        //double avg01 = 1;
        List<int> Lst02 = new List<int>() { 2 };
        //double avg02 = 2;
        List<int> Lst1 = new List<int>() { 1, 2, 3 };
        //double avg1 = 2;
        List<int> Lst2 = new List<int>() { 1, 2, 3 };
        //double avg2 = 2;
        List<int> Lst3 = new List<int>() { 2, 3, 4 };
        //double avg3 = 3;

        //Проверка корректной инициализации класса
        [TestMethod]
        public void TestTwoListsClCreateInstanceOfTypeTwoListsCl()
        {
            TwoListsCl twoListsCl00 = new TwoListsCl(Lst1, Lst2);
            Assert.IsInstanceOfType(twoListsCl00, twoListsCl00.GetType());
        }

        //Проверка средних значений списков размером больше нуля
        [TestMethod]
        public void TestAverageList1LengthMoreNull_ResultCorrectWork()
        {
            TwoListsCl twoListsCl00 = new TwoListsCl(Lst01, Lst02);
            double AvgList01 = 1;
            double ActualAvgList01 = twoListsCl00.AverageList1();
            double AvgList02 = 2;
            double ActualAvgList02 = twoListsCl00.AverageList2();
            Assert.AreEqual(AvgList01, ActualAvgList01);
            Assert.AreEqual(AvgList02, ActualAvgList02);
        }

        //Проверка средних значений, если один список пустой
        [TestMethod]
        public void TestAverageList1LengthNullList2LengthMoreThenNull_ResultCorrectWork()
        {
            TwoListsCl twoListsCl110 = new TwoListsCl(Lst01, Lst00);
            TwoListsCl twoListsCl101 = new TwoListsCl(Lst00, Lst01);

            double AvgList1101 = 1;
            double ActualAvgList1101 = twoListsCl110.AverageList1();

            double AvgList1102 = 0;
            double ActualAvgList1102 = twoListsCl110.AverageList2();

            double AvgList1011 = 0;
            double ActualAvgList1011 = twoListsCl101.AverageList1();

            double AvgList1012 = 1;
            double ActualAvgList1012 = twoListsCl101.AverageList2();

            Assert.AreEqual(AvgList1101, ActualAvgList1101);
            Assert.AreEqual(AvgList1102, ActualAvgList1102);

            Assert.AreEqual(AvgList1011, ActualAvgList1011);
            Assert.AreEqual(AvgList1012, ActualAvgList1012);
        }

        //Проверка средних значений, если один или оба списка пустые
        [TestMethod]
        public void TestAverageList1LengthNullList2LengthNull_ResultCorrectWork()
        {
            TwoListsCl twoListsCl0000 = new TwoListsCl(Lst00, Lst000);

            double AvgList00001 = 0;
            double ActualAvgList00001 = twoListsCl0000.AverageList1();

            double AvgList00002 = 0;
            double ActualAvgList00002 = twoListsCl0000.AverageList2();

            Assert.AreEqual(AvgList00001, ActualAvgList00001);
            Assert.AreEqual(AvgList00002, ActualAvgList00002);

        }
        //Проверка средних значений, если один или оба списка имеют только один элемент
        [TestMethod]
        public void TestAverageList1Length1List2Length1_ResultCorrectWork()
        {
            TwoListsCl twoListsCl12 = new TwoListsCl(Lst01, Lst02);

            double AvgList1 = 1;
            double ActualAvgList1 = twoListsCl12.AverageList1();

            double AvgList2 = 2;
            double ActualAvgList2 = twoListsCl12.AverageList2();

            Assert.AreEqual(AvgList1, ActualAvgList1);
            Assert.AreEqual(AvgList2, ActualAvgList2);
        }

        //Проверка сообщения когда среднее значение первого списка больше второго
        [TestMethod]
        public void TestComparesAvgs_AvgList1MoreThensAvgList2_ResultCorrectWork()
        {
            string AvgFirstMoreThenAvgSecond = "The first list has a higher average value";
            TwoListsCl twoListsCl01 = new TwoListsCl(Lst3, Lst2);
            string ActualAvgFirstMoreThenAvgSecond = twoListsCl01.ComparesAvgs();

            Assert.AreEqual(AvgFirstMoreThenAvgSecond, ActualAvgFirstMoreThenAvgSecond);
        }

        //Проверка сообщения когда среднее значение второго списка больше первого
        [TestMethod]
        public void TestComparesAvgs_AvgList2MoreThensAvgList1_ResultCorrectWork()
        {
            string AvgFirstMoreThenAvgSecond = "The second list has a higher average value";
            TwoListsCl twoListsCl02 = new TwoListsCl(Lst2, Lst3);
            string actualAvgFirstMoreThenAvgSecond = twoListsCl02.ComparesAvgs();

            Assert.AreEqual(AvgFirstMoreThenAvgSecond, actualAvgFirstMoreThenAvgSecond);
        }

        //Проверка сообщения когда средние значения списков равны
        [TestMethod]
        public void TestComparesAvgs_AvgList1equalAvgList2_ResultCorrectWork()
        {
            string AvgFirstMoreThenAvgSecond = "The averages of both lists are equal";
            TwoListsCl twoListsCl03 = new TwoListsCl(Lst1, Lst2);
            string actualAvgFirstMoreThenAvgSecond = twoListsCl03.ComparesAvgs();

            Assert.AreEqual(AvgFirstMoreThenAvgSecond, actualAvgFirstMoreThenAvgSecond);
        }
    }
}
