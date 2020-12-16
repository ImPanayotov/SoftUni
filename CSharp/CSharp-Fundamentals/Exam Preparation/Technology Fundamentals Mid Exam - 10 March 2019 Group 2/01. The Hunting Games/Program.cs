using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double players = int.Parse(Console.ReadLine());
            decimal energy = decimal.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            double neededWater = waterPerDay * days * players;
            double neededFood = foodPerDay * days * players;

            for (int i = 1; i <= days; i++)
            {
                decimal energyLoss = decimal.Parse(Console.ReadLine());

                if (energy - energyLoss <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {neededFood:f2} food and {neededWater:f2} water.");
                    return;
                }

                energy -= energyLoss;

                if (i % 2 == 0)
                {
                    energy *= 1.05m;
                    neededWater -= neededWater * 1.3 - neededWater;

                }
                if (i % 3 == 0)
                {
                    energy *= 1.10m;
                    neededFood -= neededFood / players;

                }
                
            }
            if (energy >= 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            
        }
    }
}
