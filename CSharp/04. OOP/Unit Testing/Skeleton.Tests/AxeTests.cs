using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLosesDurabilityAfterAttack()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        int expected = 9;
        int actual = axe.DurabilityPoints;
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void CheckIfAttackingWithBrokenWeapon()
    {
        Axe axe = new Axe(10, 0);
        Dummy dummy = new Dummy(10, 10);

        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}