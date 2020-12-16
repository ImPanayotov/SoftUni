using NUnit.Framework;
using System;
using System.Linq;


namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldBeInitializedWith16Integers()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();

            Database database = new Database(numbers);


            int expected = 16;
            int actual = database.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConstructorShouldThrowExceptionIfInitializedWithOtherThan16Integers()
        {
            int[] numbers = Enumerable.Range(1, 17).ToArray();

            Assert.Throws<InvalidOperationException>(() => new Database(numbers));
        }

        [Test]
        public void AddOperationShouldAddAnElementAtTheNextFreeCell()
        {
            Database database = new Database(1, 2, 3);

            database.Add(123);
            int[] allElements = database.Fetch();

            int expected = 123;
            int actual = allElements[3];

            int expectedCount = 4;
            int actualCount = database.Count;


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddOperationShouldThrowExceptionWhenTryingToAddMoreThan16Elements()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database database = new Database(numbers);

            Assert.Throws<InvalidOperationException>(() => database.Add(99));
        }

        [Test]
        public void RemoveOperationShouldRemoveTheLastElement()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database database = new Database(numbers);

            database.Remove();

            int expected = 15;
            int actual = database.Fetch()[14];

            int expectedCount = 15;
            int actualCount = database.Count;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, actualCount);

        }

        [Test]
        public void RemoveOperationShouldThrowExceptionIfTryingToRemoveElementFromEmptyDatabase()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FetchMethodShouldReturnTheEkementsAsAnArray()
        {
            int[] numbers = Enumerable.Range(1, 5).ToArray();
            Database database = new Database(numbers);


            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            int[] actual = database.Fetch();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}