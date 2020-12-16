using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(a, b));
        }

        private static double CalculateRectangleArea(double a, double b)
        {
            double result = a * b;
            return result;
        }
    }
}
