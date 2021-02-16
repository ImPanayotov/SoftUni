namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Pan", 100);
            robotManager = new RobotManager(3);
        }

        [Test]
        public void CheckConstructor()
        {
            Assert.AreEqual("Pan", robot.Name);
            Assert.AreEqual(100, robot.Battery);
            Assert.AreEqual(100, robot.MaximumBattery);
        }

        [Test]
        public void RobotCapacityShouldThrowExceptionWhenBelowZero()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-3));
        }

        [Test]
        public void RobotCapacityShouldShouldWorkCorrectly()
        {
            Assert.AreEqual(3, robotManager.Capacity);
        }

        [Test]
        public void CountShouldChangeWhenAddingOrRemovingRobots()
        {
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);

            robotManager.Remove(robot.Name);
            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void ShouldThrowExceptionWhenRobotExists()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        [Test]
        public void ShouldThrowExceptionWhenWhenNotEnoughCapacity()
        {
            Robot robot2 = new Robot("Pan2", 99);
            Robot robot3 = new Robot("Pan3", 98);
            Robot robot4 = new Robot("Pan4", 97);

            robotManager.Add(robot);
            robotManager.Add(robot2);
            robotManager.Add(robot3);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot4));
        }

        [Test]
        public void ShouldThrowExceptionWhenRobotToRemoveIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove(null));
        }

        [Test]
        public void WorkShouldThrowExceptionWhenRobotIsNotPresent()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work(null, null, 0));
        }

        [Test]
        public void WorkShouldThrowExceptionWhenRobotBatteryIsNotEnough()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work(robot.Name, null, 101));
        }

        [Test]
        public void WorkShouldDecreaseRobotBattery()
        {
            robotManager.Add(robot);
            robotManager.Work("Pan", "hamal", 99);
            int expected = 1;
            int actual = robot.Battery;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChargeShouldThrowExceptionWhenRobotIsNotPresent()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge(robot.Name));
        }

        [Test]
        public void ChargeShouldWorkCorrectly()
        {
            robotManager.Add(robot);
            robotManager.Work(robot.Name, "hamal", 99);
            robotManager.Charge(robot.Name);

            int expected = 100;
            int actual = robot.Battery;

            Assert.AreEqual(expected, actual);
        }
    }
}
