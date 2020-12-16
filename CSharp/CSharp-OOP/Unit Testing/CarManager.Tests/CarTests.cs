//using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SettingFuelAmountShouldBeZeroByDefault()
        {
            Car car = new Car("BMW", "318", 10, 55);

            double expected = 0;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MakeShouldWorkCorrectly()
        {
            Car car = new Car("BMW", "318", 10, 55);

            string expected = "BMW";
            string actual = car.Make;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void MakeShouldThrowArgumentExceptionWhenNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "318", 10, 55));
        }

        [Test]
        public void ModelShouldWorkCorrectly()
        {
            Car car = new Car("BMW", "318", 10, 55);

            string expected = "318";
            string actual = car.Model;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ShouldThrowArgumentExceptionWhenNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("BMW", model, 10, 55));
        }

        [Test]
        public void FuelConsumptionShouldWorkCorrectly()
        {
            Car car = new Car("BMW", "318", 10, 55);

            double expected = 10;
            double actual = car.FuelConsumption;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FuelConsumptionShouldThrowArgumentExceptionWhenEqualsOrBelowZero(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("BMW", "318", fuelConsumption, 55));
        }

        [Test]
        public void FuelCapacityShouldWorkCorrectly()
        {
            Car car = new Car("BMW", "318", 10, 55);

            double expected = 55;
            double actual = car.FuelCapacity;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FuelCapacityShouldThrowArgumentExceptionWhenEqualsOrBelowZero(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("BMW", "318", 10, fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void ReFuelAmountShouldThrowArgumentExceptionWhenEqualOrBelowZero(double fuelAmount)
        {
            Car car = new Car("BMW", "318", 10, 55);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelAmount));
        }

        [Test]
        public void ReFuelShoudIncreaseCarFuelAmount()
        {
            Car car = new Car("BMW", "318", 10, 55);

            car.Refuel(10);

            double expected = 10;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReFuelShouldFillCarFuelCapacityEvenWithMoreFuelGivenThanTheCarFuelCapacity()
        {
            Car car = new Car("BMW", "318", 10, 55);

            car.Refuel(60);

            double expected = 55;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NotEnoughFuelShouldThrowInvalidOperationExceptionWhenDrive()
        {
            Car car = new Car("BMW", "318", 10, 55);

            Assert.Throws<InvalidOperationException>(() => car.Drive(1));
        }

        [Test]
        public void FuelAmountShouldDecreaseWhenDrive()
        {
            Car car = new Car("BMW", "318", 10, 55);

            car.Refuel(55);

            double expected = 54;
            car.Drive(10);

            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }
    }
}