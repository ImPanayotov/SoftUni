using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Item item = new Item("owner", "id");

            Assert.AreEqual("owner", item.Owner);
            Assert.AreEqual("id", item.ItemId);
        }

        [Test]
        public void AddItemCellNotExists()
        {
            Item item = new Item("owner", "id");

            BankVault bankVault = new BankVault();

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A5", item));
        }

        [Test]
        public void AddItemCellIsOccupied()
        {
            Item item = new Item("owner", "id");
            Item item2 = new Item("owner2", "id2");

            BankVault bankVault = new BankVault();
            bankVault.AddItem("A4", item);

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A4", item2));
        }

        [Test]
        public void IfCellExists()
        {
            BankVault bankVault = new BankVault();
            Item item = new Item("owner", "id");

            var vaultCells = new Dictionary<string, Item>
            {
                {"A1", item}
            };

            bankVault.AddItem("A1", item);

            Assert.AreEqual(true, vaultCells.Values.Any(x => x.ItemId == item.ItemId));

        }


        [Test]
        public void remove()
        {
            Item item = new Item("owner", "id");
            Item item2 = new Item("owner2", "id2");

            BankVault bankVault = new BankVault();
            bankVault.AddItem("A4", item);

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A1456", item2));

        }
        
        
    }
}

