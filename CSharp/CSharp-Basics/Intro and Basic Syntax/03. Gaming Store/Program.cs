using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string input = "";
            double price = 0;
            double remainingBalance = currentBalance;
            double totalSpent = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Game Time")
                {
                    break;
                }

                price = 0;

                switch (input)
                {
                    case "OutFall 4": price += 39.99; break;
                    case "CS: OG": price += 15.99; break;
                    case "Zplinter Zell": price += 19.99; break;
                    case "Honored 2": price += 59.99; break;
                    case "RoverWatch": price += 29.99; break;
                    case "RoverWatch Origins Edition": price = +39.99; break;
                    default: Console.WriteLine("Not Found"); continue;
                }
                if (remainingBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                remainingBalance -= price;
                totalSpent += price;

                Console.WriteLine($"Bought {input}");

                if (remainingBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${remainingBalance:f2}");
        }
    }
}
