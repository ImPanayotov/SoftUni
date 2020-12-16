namespace Computers.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PartConstructor()
        {
            Part part = new Part("part", 1.1m);

            Assert.AreEqual("part", part.Name);
            Assert.AreEqual(1.1m, part.Price);
        }

        [Test]
        public void NameThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => new Computer(null));
        }

        [Test]
        public void NameWorks()
        {
            Computer pc = new Computer("PC");
            Assert.AreEqual("PC", pc.Name);
        }

        [Test]
        public void Price()
        {
            List<Part> parts = new List<Part>();
            Part part1 = new Part("part1", 1.0m);
            Part part2 = new Part("part2", 10.0m);
            parts.Add(part1);
            parts.Add(part2);

            Computer pc = new Computer("PC");
            pc.AddPart(part1);
            pc.AddPart(part2);

            var expected = 11m;
            var actual = pc.TotalPrice;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPartException()
        {
            Computer pc = new Computer("PC");
            Part part = null;

            Assert.Throws<InvalidOperationException>(() => pc.AddPart(part));
        }

        [Test]
        public void AddPartAddsPart()
        {
            Computer pc = new Computer("PC");
            Part part = new Part("part", 1.1m);
            pc.AddPart(part);

            Assert.AreEqual(1, pc.Parts.Count);
        }

        [Test]
        public void RemovePart()
        {
            Computer pc = new Computer("PC");
            Part part = new Part("part", 1.1m);
            pc.AddPart(part);

            Assert.AreEqual(1, pc.Parts.Count);
            pc.RemovePart(part);
            Assert.AreEqual(0, pc.Parts.Count);
        }

        [Test]
        public void GetPart()
        {
            Part part1 = new Part("part1", 1.0m);
            Part part2 = new Part("part2", 10.0m);


            Computer pc = new Computer("PC");

            pc.AddPart(part1);
            pc.AddPart(part2);

            var expected = part1;
            var actual = pc.GetPart("part1");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestConstructor()
        {
            Computer pc = new Computer("PC");
            List<Part> parts = new List<Part>();
            Part part1 = new Part("part1", 1.0m);
            Part part2 = new Part("part2", 10.0m);
            parts.Add(part1);
            parts.Add(part2);
            pc.AddPart(part1);
            pc.AddPart(part2);

            Assert.AreEqual("PC", pc.Name);
            Assert.AreEqual(2, pc.Parts.Count);
        }
    }
}