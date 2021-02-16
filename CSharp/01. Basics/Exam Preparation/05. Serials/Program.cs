using System;

namespace _05._Serials
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serials = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            for (int serial = 1; serial <= serials; serial++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch (name)
                {
                    case "Thrones": price = 0.5 * price; break;
                    case "Lucifer": price = 0.6 * price; break;
                    case "Protector": price = 0.7 * price; break;
                    case "TotalDrama": price = 0.8 * price; break;
                    case "Area": price = 0.9 * price; break;

                }
                totalPrice += price;
            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"You bought all the series and left with {leftMoney:F2} lv.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"You need {needMoney:F2} lv. more to buy the series!");
            }   
        }
    }
}
