using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int gpuPrice = 250;
            

            double budget = double.Parse(Console.ReadLine());
            int gpuQty = int.Parse(Console.ReadLine());
            int cpuQty = int.Parse(Console.ReadLine());
            int ramQty = int.Parse(Console.ReadLine());

            double cpuPrice = (gpuPrice * gpuQty) * 0.35;
            double ramPrice = (gpuPrice * gpuQty) * 0.10;

            double spendings = gpuQty * gpuPrice + cpuQty * cpuPrice + ramQty * ramPrice;
            if (gpuQty > cpuQty)
            {
                if (budget >= spendings)
                {
                    double moneyLeft = budget - spendings * 0.85;
                    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
                }
                else
                {
                    double moneyNeeded = Math.Abs(budget - spendings * 0.85);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
                }
            }
            else
            {
                if (budget >= spendings)
                {
                    double moneyLeft = budget - spendings;
                    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
                }
                else
                {
                    double moneyNeeded = Math.Abs(budget - spendings);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
                }
            }

        }
    }
}
