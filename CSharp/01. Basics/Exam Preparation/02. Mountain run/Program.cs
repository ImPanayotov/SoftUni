using System;

namespace _02._Mountain_run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double climbOneMeter = double.Parse(Console.ReadLine());

            double timeToTop = distance * climbOneMeter;
            double slowDown = Math.Floor(distance / 50) * 30;
            double totalTimeToTop = timeToTop + slowDown;
            if (totalTimeToTop >= record)
            {
                Console.WriteLine($"No! He was {(totalTimeToTop - record):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {(totalTimeToTop):f2} seconds.");
            }
        }
    }
}
