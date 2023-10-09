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
            int exeptedNumWheelsOfCar = 4;
            int actualNumWheelsOfNewCar = testCar.NumWheels;
            Assert.AreEqual(exeptedNumWheelsOfCar, actualNumWheelsOfNewCar);
        }

        [TestMethod]
        public void TestNumWheelsOfNewMotorcycle_Returns2()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int exeptedNumWheelsOfMotorcycle = 2;
            int actuaNumWheelsOfNewMotorcycle = testMotorcycle.NumWheels;
            Assert.AreEqual(exeptedNumWheelsOfMotorcycle, actuaNumWheelsOfNewMotorcycle);
        }

        //- Проверить, что объект Car развивает скорость 60 в режиме тестового вождения
        //(используя метод testDrive()).
        //-  Проверить, что объект Motorcycle развивает скорость 75 в режиме тестового
        //вождения (используя метод testDrive()).

        [TestMethod]
        public void TestTestDriveSpeeedOfCar_Returns60()
        {
            Car testCar = new Car();
            int exeptedTestDriveSpeeedOfCar = 60;
            testCar.TestDrive();
            int actualTestDriveSpeeedOfCar = testCar.Speed;
            Assert.AreEqual(exeptedTestDriveSpeeedOfCar, actualTestDriveSpeeedOfCar);
        }

        [TestMethod]
        public void TestTestDriveSpeeedOfMotorcycle_Returns75()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int exeptedTestDriveSpeeedOfMotorcycle = 75;
            testMotorcycle.TestDrive();
            int actualTestDriveSpeeedOfMotorcycle = testMotorcycle.Speed;
            Assert.AreEqual(exeptedTestDriveSpeeedOfMotorcycle, actualTestDriveSpeeedOfMotorcycle);
        }

        //-Проверить, что в режиме парковки (сначала testDrive, потом park,
        //т.е. эмуляция движения транспорта) машина останавливается(speed = 0).
        //-Проверить, что в режиме парковки (сначала testDrive, потом park,
        //т.е. эмуляция движения транспорта) мотоцикл останавливается(speed = 0).

        [TestMethod]
        public void TestTestDriveAndParkSpeeedOfCar_Returns0()
        {
            Car testCar = new Car();
            int exeptedParkSpeeedOfCar = 0;
            testCar.TestDrive();
            testCar.Park();
            int actualTestDriveSpeeedOfCar = testCar.Speed;
            Assert.AreEqual(exeptedParkSpeeedOfCar, actualTestDriveSpeeedOfCar);
        }

        [TestMethod]
        public void TestTestDriveAndParkSpeeedOfMotorcycle_Returns0()
        {
            Motorcycle testMotorcycle = new Motorcycle();
            int exeptedParkSpeeedOfMotorcycle = 0;
            testMotorcycle.TestDrive();
            testMotorcycle.Park();
            int actualTestDriveSpeeedOfMotorcycle = testMotorcycle.Speed;
            Assert.AreEqual(exeptedParkSpeeedOfMotorcycle, actualTestDriveSpeeedOfMotorcycle);
        }
    }
}
