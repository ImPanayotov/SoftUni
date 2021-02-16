//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior deffender;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            attacker = new Warrior("Pan", 10, 80);
            deffender = new Warrior("Pan2", 5, 50);
        }

        [Test]
        public void ConstructorShouldWorkAsExpected()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void CountShouldWorkAsExpected()
        {
            Assert.AreEqual(0, arena.Warriors.Count);
        }

        [Test]
        public void EnrollMethodShoudThrowInvalidOperationExceptionWhenWarriorIsAlreadyEnrolled()
        {
            Warrior warriorToEnroll = new Warrior("Pan", 100, 100);

            arena.Enroll(warriorToEnroll);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warriorToEnroll));
        }

        [Test]
        public void EnrollMethodShouldWorkCorrectlyWhenAddingNewOriginalWarrior()
        {
            Warrior warriorToEnroll = new Warrior("Pan", 100, 100);

            int expectedCount = 1;

            arena.Enroll(warriorToEnroll);

            Assert.That(arena.Count, Is.EqualTo(expectedCount));
            Assert.That(arena.Warriors, Has.Member(warriorToEnroll));
        }

        [Test]
        public void FightSHouldThrowExceptionWhenAttackerIsMissing()
        {
            arena.Enroll(deffender);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, deffender.Name));
        }

        [Test]
        public void FightSHouldThrowExceptionWhenDefenderIsMissing()
        {
            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() =>
                    arena.Fight(attacker.Name, deffender.Name));
        }

        [Test]
        public void FightSHouldThrowExceptionWhenBothFightersAreMissing()
        {
            Assert.Throws<InvalidOperationException>(() =>
                    arena.Fight(attacker.Name, deffender.Name));
        }

        [Test]
        public void FightShouldWorkWithCorrectParameters()
        {
            int expectedAttackerHp = attacker.HP - deffender.Damage;
            int expectedDeffenderHp = deffender.HP - attacker.Damage;

            arena.Enroll(attacker);
            arena.Enroll(deffender);

            arena.Fight(attacker.Name, deffender.Name);

            Assert.That(attacker.HP, Is.EqualTo(expectedAttackerHp));
            Assert.That(deffender.HP, Is.EqualTo(expectedDeffenderHp));
        }
    }
}
