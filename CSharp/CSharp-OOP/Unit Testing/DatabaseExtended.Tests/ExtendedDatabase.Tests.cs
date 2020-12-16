//using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [Test]
        public void ConstructorOfPersonShouldWorkCorrectly()
        {
            Person person = new Person(132, "Pan");
            long expectedID = 132;
            string expectedUserName = "Pan";

            long actualID = person.Id;
            string actualUSer = person.UserName;

            Assert.That(actualUSer, Is.EqualTo(expectedUserName));
            Assert.That(actualID, Is.EqualTo(expectedID));

        }

        [Test]
        public void FindByIDShouldWorkCorrectly()
        {
            Person[] persons = new Person[]
            {
                new Person(132, "Pan"),
                new Person(21234567890, "Pan2")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);

            Person expectedPerson = new Person(132, "Pan");

            long searchedID = 132;

            Assert.That(extendedDatabase.FindById(searchedID).Id, Is.EqualTo(expectedPerson.Id));
        }

        [Test]
        public void FindByNameShouldWorkCorrectly()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(21234567890, "Pan2")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);
            Person expectedPerson = new Person(132, "Pan");
            string searchedName = "Pan";

            Assert.That(extendedDatabase.FindByUsername(searchedName).UserName, Is.EqualTo(expectedPerson.UserName));
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenCountZero()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan1"),
                new Person(21234567890, "Pan2")
            };
            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);
            extendedDatabase.Remove();
            extendedDatabase.Remove();
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.Remove();
            });
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan1"),
                new Person(21234567890, "Pan2"),
                new Person(31234567890, "Pan3"),
                new Person(41234567890, "Pan4"),
                new Person(51234567890, "Pan5"),
                new Person(61234567890, "Pan6"),
                new Person(71234567890, "Pan7"),
                new Person(81234567890, "Pan8"),
                new Person(91234567890, "Pan9"),
                new Person(101234567890, "Pan10"),
                new Person(111234567890, "Pan11"),
                new Person(121234567890, "Pan12"),
                new Person(131234567890, "Pan13"),
                new Person(141234567890, "Pan14"),
                new Person(151234567890, "Pan15"),
                new Person(161234567890, "Pan16")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);

            int expectedCount = 15;
            extendedDatabase.Remove();

            int actualCount = extendedDatabase.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }

        [Test]
        public void AddOperationShouldThrowExceptionWhenTryingToAddMoreThan16Persons()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan1"),
                new Person(21234567890, "Pan2"),
                new Person(31234567890, "Pan3"),
                new Person(41234567890, "Pan4"),
                new Person(51234567890, "Pan5"),
                new Person(61234567890, "Pan6"),
                new Person(71234567890, "Pan7"),
                new Person(81234567890, "Pan8"),
                new Person(91234567890, "Pan9"),
                new Person(101234567890, "Pan10"),
                new Person(111234567890, "Pan11"),
                new Person(121234567890, "Pan12"),
                new Person(131234567890, "Pan13"),
                new Person(141234567890, "Pan14"),
                new Person(151234567890, "Pan15"),
                new Person(161234567890, "Pan16")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);
            Person person = new Person(123, "testing");

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }

        
        [Test]
        public void ConstructorShouldThrowExceptionIfInitializedWithOtherThan16Persons()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan1"),
                new Person(21234567890, "Pan2"),
                new Person(31234567890, "Pan3"),
                new Person(41234567890, "Pan4"),
                new Person(51234567890, "Pan5"),
                new Person(61234567890, "Pan6"),
                new Person(71234567890, "Pan7"),
                new Person(81234567890, "Pan8"),
                new Person(91234567890, "Pan9"),
                new Person(101234567890, "Pan10"),
                new Person(111234567890, "Pan11"),
                new Person(121234567890, "Pan12"),
                new Person(131234567890, "Pan13"),
                new Person(141234567890, "Pan14"),
                new Person(151234567890, "Pan15"),
                new Person(161234567890, "Pan16")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);
            Person person = new Person(123, "testing");

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }

        [Test]
        public void ConstructorShouldBeInitializedWith16Persons()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan1"),
                new Person(21234567890, "Pan2"),
                new Person(31234567890, "Pan3"),
                new Person(41234567890, "Pan4"),
                new Person(51234567890, "Pan5"),
                new Person(61234567890, "Pan6"),
                new Person(71234567890, "Pan7"),
                new Person(81234567890, "Pan8"),
                new Person(91234567890, "Pan9"),
                new Person(101234567890, "Pan10"),
                new Person(111234567890, "Pan11"),
                new Person(121234567890, "Pan12"),
                new Person(131234567890, "Pan13"),
                new Person(141234567890, "Pan14"),
                new Person(151234567890, "Pan15"),
                new Person(161234567890, "Pan16")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);

            int expected = 16;
            int actual = extendedDatabase.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddingUserWithExistingUsernameShouldThrowException()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(2234567890, "Pan2"),
                new Person(3234567890, "Pan3")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);

            Person person = new Person(2234567890, "Pan");


            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }

        [Test]
        public void AddingUserWithExistingIdShouldThrowException()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(2234567890, "Pan2"),
                new Person(3234567890, "Pan3")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);

            Person person = new Person(1234567890, "Pan2");


            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }

        [Test]
        public void FailingToFindUserByGivenUsernameShouldThrowInvalidOperationException()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(2234567890, "Pan2"),
                new Person(3234567890, "Pan3")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);


            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("Pan12"));
        }

        [Test]
        public void FailingToFindUserByGivenNullOrEmptyUsernameShouldThrowArgumentNullException()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(2234567890, "Pan2"),
                new Person(3234567890, "Pan3")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);


            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(null));
        }

        [Test]
        public void FailingToFindUserByGivenNegativeIdShouldThrowArgumentOutOfRangeException()
        {
            Person[] persons = new Person[]
            {
                new Person(1234567890, "Pan"),
                new Person(2234567890, "Pan2"),
                new Person(3234567890, "Pan3")
            };

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(persons);


            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(-1234));
        }
        
    }
}