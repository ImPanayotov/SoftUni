using NUnit.Framework;
using System;

namespace Computers.Tests
{
    public class Tests
    {
        private Computer pc;
        private ComputerManager pcMngr;

        [SetUp]
        public void Setup()
        {
            pc = new Computer("Dell", "Vostro", 1199.99m);
            pcMngr = new ComputerManager();
        }

        [Test]
        public void ConstructorShouldWorkAsExpected()
        {
            Computer computer = new Computer("Dell", "Vostro", 1199.99m);

            string expectedName = "Dell";
            string expectedModel = "Vostro";
            decimal expectedPrice = 1199.99m;

            string actualName = computer.Manufacturer;
            string actualModel = computer.Model;
            decimal actualPrice = computer.Price;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedModel, actualModel);
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [Test]
        public void ChechPCMngrCount()
        {
            pcMngr.AddComputer(pc);

            Assert.AreEqual(1, pcMngr.Count);
        }

        [Test]
        public void ValidateNullValueMethodShouldThrowExceptionWhenObjectIsNull()
        {
            Computer nullPC = null;
            Computer nullPC2 = new Computer(null, "Vostro", 1199.99m);

            Assert.Throws<ArgumentNullException>(() => pcMngr.AddComputer(nullPC));
            Assert.Throws<ArgumentNullException>(() => pcMngr.GetComputer(null, "Vostro"));
            Assert.Throws<ArgumentNullException>(() => pcMngr.GetComputer("Vostro", null));
        }

        [Test]
        public void AddComputerShouldThrowExceptionWhenTryingToAddExistingPC()
        {
            pcMngr.AddComputer(pc);

            Assert.Throws<ArgumentException>(() => pcMngr.AddComputer(pc));
        }

        [Test]
        public void AddComputerShouldWorkAsExpected()
        {
            pcMngr.AddComputer(pc);

            Assert.AreEqual(1, pcMngr.Count);
        }

        [Test]
        public void RemoveComputerShouldWorkAsExpected()
        {
            pcMngr.AddComputer(pc);

            pcMngr.RemoveComputer("Dell", "Vostro");

            Assert.AreEqual(0, pcMngr.Count);
        }

        [Test]
        public void RemoveComputerShouldThrowExceptionWhenThereIsNoComputerWithSameParamteres()
        {
            Computer nullPC = null;

            Assert.Throws<ArgumentException>(() => pcMngr.RemoveComputer("Dell", "Vostro"));
        }

        
    }
}