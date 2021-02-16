using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLoseHealthWhenAttacked()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(1);

        int expected = 9;
        int actual = dummy.Health;

        Assert.AreEqual(expected, actual);
    }

    [Test]
    
    public void DeadDummyShouldThrowExceptionIfAttacked()
    {
        Dummy dummy = new Dummy(0, 10);

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
    }

    [Test]
    public void DeadDummyShouldGiveExpWhenAttacked()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(10);

        int expected = 10;
        int actual = dummy.GiveExperience();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AliveDummyShouldNotGiveExpWhenAttacked()
    {
        Dummy dummy = new Dummy(100, 10);

        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

    }

}
