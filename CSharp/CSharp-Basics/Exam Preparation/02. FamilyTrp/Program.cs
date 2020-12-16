using System;

namespace _02._FamilyTrp
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int sideSpendings = int.Parse(Console.ReadLine());

            double nightsTotatlPrice = pricePerNight * nights;
            double spendings = budget * sideSpendings / 100;
           
            if (nights > 7)
            {
                nightsTotatlPrice = nightsTotatlPrice * 0.95;

                if (budget >= nightsTotatlPrice + spendings)
                {
                    Console.WriteLine($"Ivanovi will be left with {budget - spendings - nightsTotatlPrice:f2} leva after vacation.");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(budget - spendings - nightsTotatlPrice):f2} leva needed.");
                }

            }
            else
            {
                if (budget >= nightsTotatlPrice + spendings)
                {
                    Console.WriteLine($"Ivanovi will be left with {budget - spendings - nightsTotatlPrice:f2} leva after vacation.");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(budget - spendings - nightsTotatlPrice):f2} leva needed.");
                }
            }







        }
    }
}
