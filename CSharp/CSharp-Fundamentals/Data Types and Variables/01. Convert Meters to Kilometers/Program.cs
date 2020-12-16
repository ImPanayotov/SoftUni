using System;
using System.Numerics;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometeres = meters / 1000M;
            Console.WriteLine($"{kilometeres:f2}");
        }
    }
}
