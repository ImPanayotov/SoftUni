using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeOneMeterPerSecond = double.Parse(Console.ReadLine());
            double resistance = Math.Floor(distanceMeters / 15);
            double delaySecond = resistance * 12.5;
            double totalTimeIvan = distanceMeters * timeOneMeterPerSecond + delaySecond;

            if (totalTimeIvan >= record)
            {
                Console.WriteLine($"No, he failed! He was {totalTimeIvan - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeIvan:f2} seconds.");
            }
        }
    }
}
