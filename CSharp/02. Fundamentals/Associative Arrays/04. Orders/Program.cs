using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, long> productsQty = new Dictionary<string, long>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productsArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = productsArgs[0];
                decimal price = decimal.Parse(productsArgs[1]);
                int qty = int.Parse(productsArgs[2]);

                if (!productsQty.ContainsKey(name))
                {
                    productPrice[name] = 0m;
                    productsQty[name] = 0;
                }

                productsQty[name] += qty;
                productPrice[name] = price;
            }

            foreach (var kvp in productPrice)
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                long qty = productsQty[name];
                decimal totalPrice = price * qty;

                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}
