using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] times = Console.ReadLine().Split().Select(double.Parse).ToArray();


            double leftRacerTime = GetSum(times);

            times = times
                .Reverse()
                .ToArray();

            double rightRacerTime = GetSum(times);

            if (leftRacerTime <= rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else //if (leftRacerTime > rightRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
        public static double GetSum(double[] times)
        {
            double sum = 0;
            for (int i = 0; i < times.Length / 2; i++)
            {
                if (times[i] == 0)
                {
                    sum *= 0.8;
                }
                else
                {
                    sum += times[i];
                }
            }
            return sum;
        }
    }
}
