using Bakery.Models.BakedFoods;
using Bakery.Models.Drinks;
using Bakery.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core.Contracts
{
    public class Controller : IController
    {
        private List<BakedFood> foods;
        private List<Drink> drinks;
        private List<Table> tables;
        private decimal totalIncome;

        public Controller()
        {
            foods = new List<BakedFood>();
            drinks = new List<Drink>();
            tables = new List<Table>();

        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            Drink drink = null;

            if (type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            else if (type == "Water")
            {
                drink = new Water(name, portion, brand);
            }

            if (drink != null)
            {
                drinks.Add(drink);

                return $"Added {name} ({brand}) to the menu";
            }

            return null; // To be checked later!
        }

        public string AddFood(string type, string name, decimal price)
        {
            BakedFood food = null;

            if (type == "Bread")
            {
                food = new Bread(name, price);
            }
            else if (type == "Cake")
            {
                food = new Cake(name, price);
            }



            if (food != null)
            {
                foods.Add(food);

                return $"Added {name} ({type}) to the menu";
            }

            return null; // To be checked later!
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            Table table = null;

            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else if (type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber, capacity);
            }

            if (table != null)
            {
                tables.Add(table);

                return $"Added table number {tableNumber} in the bakery";
            }

            return null; // To be checked later!
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder result = new StringBuilder();
            foreach (var table in tables)
            {
                if (table.IsReserved == false)
                {
                    result.AppendLine(table.GetFreeTableInfo());
                }
            }

            return result.ToString().Trim();
        }

        public string GetTotalIncome()
        {
            return $"Total income: {totalIncome:f2}";
        }

        public string LeaveTable(int tableNumber)
        {
            var table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var bill = table.GetBill();

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Table: {tableNumber}");
            result.AppendLine($"Bill: {bill:f2}");
            totalIncome += bill + table.Price;// check if it works

            tables.Add(table);
            table.Clear();
            return result.ToString().Trim();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            if (!tables.Any(x => x.TableNumber == tableNumber))
            {
                return $"Could not find table {tableNumber}";
            }

            if (!drinks.Any(x => x.Name == drinkName)) // may be it should check it by brand? or both?
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }

            var table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var drink = drinks.FirstOrDefault(x => x.Name == drinkName);
            table.OrderDrink(drink);

            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";

        }

        public string OrderFood(int tableNumber, string foodName)
        {
            if (!tables.Any(x => x.TableNumber == tableNumber))
            {
                return $"Could not find table {tableNumber}";
            }

            if (!foods.Any(x => x.Name == foodName))
            {
                return $"No {foodName} in the menu";
            }

            var table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var food = foods.FirstOrDefault(x => x.Name == foodName);
            table.OrderFood(food);

            //tables.Add(table);//may be it shouldnt create another table?

            return $"Table {tableNumber} ordered {foodName}";
        }

        public string ReserveTable(int numberOfPeople)
        {
            Table freeTable = null;
            foreach (var table in tables.OrderBy(x => x.TableNumber))
            {
                if (table.IsReserved == false)
                {
                    if (numberOfPeople <= table.Capacity)
                    {
                        freeTable = table;
                        break;
                    }
                }
            }


            if (freeTable != null)
            {
                var table = tables.FirstOrDefault(x => x.IsReserved == false && x.NumberOfPeople >= numberOfPeople);
                freeTable.IsReserved = true;

                tables.Add(freeTable);

                return $"Table {freeTable.TableNumber} has been reserved for {numberOfPeople} people";
            }

            return $"No available table for {numberOfPeople} people"; // to be checked if needs to trhow exception


        }
    }
}
