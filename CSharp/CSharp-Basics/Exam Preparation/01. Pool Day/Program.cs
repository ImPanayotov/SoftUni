using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = int.Parse(Console.ReadLine());
            double entryFee = double.Parse(Console.ReadLine());
            double chairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntryFee = entryFee * peopleCount;
            double chairs = Math.Ceiling(peopleCount * 0.75);
            double umbrellas = Math.Ceiling(peopleCount / 2.0);
            double final = totalEntryFee + chairs * chairPrice + umbrellas * umbrellaPrice;

            Console.WriteLine($"{final:f2}");


        }
    }
}
