using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collection = Console.ReadLine()
                .Split("|")
                .ToArray();

            decimal budget = decimal.Parse(Console.ReadLine());
            decimal originalBudget = budget;
            decimal profit = 0.0m;

            List<decimal> newCollection = new List<decimal>();

            for (int i = 0; i < collection.Length; i++)
            {
                string[] product = collection[i].Split("->").ToArray();

                string type = product[0];
                decimal price = decimal.Parse(product[1]);

                if (type == "Clothes")
                {
                    if (price <= 50.00m)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            profit += price * 1.4m - price;
                            price *= 1.4m;
                            newCollection.Add(price);
                        }
                    }
                }
                else if (type == "Shoes")
                {
                    if (price <= 35.00m)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            profit += price * 1.4m - price;
                            price *= 1.4m;
                            newCollection.Add(price);

                        }
                    }
                }
                else if (type == "Accessories")
                {
                    if (price <= 20.50m)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            profit += price * 1.4m - price;
                            price *= 1.4m;
                            newCollection.Add(price);

                        }
                    }
                }
            }

            foreach (var item in newCollection)
            {
                Console.Write($"{item:f2} ");
            }

            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:f2}");

            if (originalBudget + profit >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
