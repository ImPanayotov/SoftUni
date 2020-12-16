using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (product)
            {
                case "coffee":
                     price = 1.50;
                    PrintOrder(quantity, price);
                    break;
                case "water":
                     price = 1.00;
                    PrintOrder(quantity, price);
                    break;
                case "coke":
                     price = 1.40;
                    PrintOrder(quantity, price);
                    break;
                case "snacks":
                     price = 2.00;
                    PrintOrder(quantity, price);
                    break;
            }
            
        }

        static void PrintOrder(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
    }
}
