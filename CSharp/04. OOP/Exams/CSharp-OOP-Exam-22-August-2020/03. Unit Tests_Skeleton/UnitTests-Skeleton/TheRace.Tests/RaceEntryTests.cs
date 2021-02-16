using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldWork()
        {
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);

            Assert.AreEqual("Unit", unitCar.Model);
            Assert.AreEqual(150, unitCar.HorsePower);
            Assert.AreEqual(2000.0, unitCar.CubicCentimeters);
        }

        [Test]
        public void NameShouldWork()
        {
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);

            UnitDriver unitDriver = new UnitDriver("Driver", unitCar);

            Assert.AreEqual("Driver", unitDriver.Name);
        }

        [Test]
        public void AddDriverShouldWork()
        {
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);

            RaceEntry drivers = new RaceEntry();
            UnitDriver driver = new UnitDriver("Driver", unitCar);
            drivers.AddDriver(driver);

            Assert.AreEqual(1, drivers.Counter);
        }

        [Test]
        public void AddDriverExceptionWhenNull()
        {
            RaceEntry drivers = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => drivers.AddDriver(null));
        }

        [Test]
        public void AddDriverExceptionWhenExisting()
        {
            RaceEntry drivers = new RaceEntry();
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);
            UnitDriver driver = new UnitDriver("Driver", unitCar);

            drivers.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => drivers.AddDriver(driver));
        }

        [Test]
        public void CalculateAvgHorsePowerShouldWorkCorrectly()
        {
            RaceEntry drivers = new RaceEntry();
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);
            UnitCar unitCar2 = new UnitCar("Unit2", 150, 2000.0d);
            UnitDriver driver = new UnitDriver("Driver", unitCar);
            UnitDriver driver2 = new UnitDriver("Driver2", unitCar2);

            drivers.AddDriver(driver);
            drivers.AddDriver(driver2);

            double expected = 150;
            double actual = drivers.CalculateAverageHorsePower();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateAvgHorsePowerShouldThrowException()
        {
            RaceEntry drivers = new RaceEntry();
            UnitCar unitCar = new UnitCar("Unit", 150, 2000.0d);
            UnitDriver driver = new UnitDriver("Driver", unitCar);

            drivers.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => drivers.CalculateAverageHorsePower());
        }
    }
}