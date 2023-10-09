using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Tests
{
    [TestClass]
    public class CarTests
    {
        //-Проверить, что экземпляр объекта Car также является экземпляром транспортного 
        //    средства (используя оператор instanceof).
        [TestMethod]
        public void TestCarInstanceOfTypeVehicle()
        {
            Car testCar = new Car();
            Assert.IsInstanceOfType(testCar, testCar.GetType());
        }

        [TestMethod]
        public void TestWrongInstanceofType()
        {
            Car testCar = new Car();
            Motorcycle testMotorcycle = new Motorcycle();
            Assert.IsInstanceOfType(testCar, testMotorcycle.GetType());
        }

        //-Проверить, что объект Car создается с 4-мя колесами.
        //- Проверить, что объект Motorcycle создается с 2-мя колесами.


        [TestMethod]
        public void TestNumWheelsOfNewCar_Returns4()
        {
            Car testCar = new Car();
            int correctNumWheelsOfCar = 4;
            int numWheelsOfNewCar = testCar.NumWheels;
            Assert.AreEqual(correctNumWheelsOfCar, numWheelsOfNewCar);
        }

        [TestMethod]
        public void TestNumWheelsOfNewMotorcycle_Returns2()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int correctNumWheelsOfMotorcycle = 2;
            int numWheelsOfNewMotorcycle = testMotorcycle.NumWheels;
            Assert.AreEqual(correctNumWheelsOfMotorcycle, numWheelsOfNewMotorcycle);
        }

        //- Проверить, что объект Car развивает скорость 60 в режиме тестового вождения
        //(используя метод testDrive()).
        //-  Проверить, что объект Motorcycle развивает скорость 75 в режиме тестового
        //вождения (используя метод testDrive()).

        [TestMethod]
        public void TestTestDriveSpeeedOfCar_Returns60()
        {
            Car testCar = new Car();
            int correctTestDriveSpeeedOfCar = 60;
            testCar.TestDrive();
            int testDriveSpeeedOfCar = testCar.Speed;
            Assert.AreEqual(correctTestDriveSpeeedOfCar, testDriveSpeeedOfCar);
        }

        [TestMethod]
        public void TestTestDriveSpeeedOfMotorcycle_Returns75()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int correctTestDriveSpeeedOfMotorcycle = 75;
            testMotorcycle.TestDrive();
            int testDriveSpeeedOfMotorcycle = testMotorcycle.Speed;
            Assert.AreEqual(correctTestDriveSpeeedOfMotorcycle, testDriveSpeeedOfMotorcycle);
        }

        //-Проверить, что в режиме парковки (сначала testDrive, потом park,
        //т.е. эмуляция движения транспорта) машина останавливается(speed = 0).
        //-Проверить, что в режиме парковки (сначала testDrive, потом park,
        //т.е. эмуляция движения транспорта) мотоцикл останавливается(speed = 0).

        [TestMethod]
        public void TestTestDriveAndParkSpeeedOfCar_Returns0()
        {
            Car testCar = new Car();
            int correctParkSpeeedOfCar = 0;
            testCar.TestDrive();
            testCar.Park();
            int testDriveSpeeedOfCar = testCar.Speed;
            Assert.AreEqual(correctParkSpeeedOfCar, testDriveSpeeedOfCar);
        }

        [TestMethod]
        public void TestTestDriveAndParkSpeeedOfMotorcycle_Returns0()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int correctParkSpeeedOfMotorcycle = 0;
            testMotorcycle.TestDrive();
            testMotorcycle.Park();
            int testDriveSpeeedOfMotorcycle = testMotorcycle.Speed;
            Assert.AreEqual(correctParkSpeeedOfMotorcycle, testDriveSpeeedOfMotorcycle);
        }
    }
}
