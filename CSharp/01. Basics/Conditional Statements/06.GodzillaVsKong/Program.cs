using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.1;
            double priceClothes = countStatists * pricePerStatist;
            if (countStatists > 150)
            {
                priceClothes = priceClothes - 0.10 * priceClothes;

            }
            double total = priceDecor + priceClothes;
            if (total > budget)
            {

                Console.WriteLine("Not enough money!");
                double needMoney = total - budget;
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - total;
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }

        }


    }
}
