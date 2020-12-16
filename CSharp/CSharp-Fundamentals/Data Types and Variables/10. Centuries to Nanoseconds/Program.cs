using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            ulong minutes = (ulong) (60 * hours);
            ulong seconds = (ulong) (60 * minutes);
            ulong milliseconds =  (ulong) (1000 * seconds);
            decimal microseconds = 1000 * milliseconds;
            decimal nanoseconds = 1000 * microseconds;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
