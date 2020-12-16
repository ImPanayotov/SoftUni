using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable

    {
        private List<IBakedFood> FoodOrders;
        private List<IDrink> DrinkOrders;
        private List<Table> tables;
        private int capacity;
        private int numberOfPeople;
        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            tables = new List<Table>();
            FoodOrders = new List<IBakedFood>();
            DrinkOrders = new List<IDrink>();
        }

        public int TableNumber { get; private set; }

        //•	Capacity – int the table capacity(capacity can’t be less than zero.In these cases, throw an ArgumentException with message "Capacity has to be greater than 0")
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get;  set; }

        public decimal Price { get { return PricePerPerson * NumberOfPeople; } }

        public void Clear()
        {
            FoodOrders.Clear();
            DrinkOrders.Clear();
            NumberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal bill = DrinkOrders.Sum(x => x.Price) + FoodOrders.Sum(x => x.Price) + Price;
            return bill;
        }

        public string GetFreeTableInfo()
        {

            StringBuilder result = new StringBuilder();

            result.AppendLine($"Table: {TableNumber}");
            result.AppendLine($"Type: {GetType().Name}");
            result.AppendLine($"Capacity: {Capacity}");
            result.AppendLine($"Price per Person: {PricePerPerson}");

            return result.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            DrinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            FoodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            //if (Capacity >= numberOfPeople)
            //{
            NumberOfPeople = numberOfPeople;
            IsReserved = true;
            //}

        }
    }
}
