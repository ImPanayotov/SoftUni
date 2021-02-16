using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangelArea(width, height);
            Console.WriteLine(area);
        }

        static double GetTriangelArea(double width, double height)
        {
            
            return Math.Abs(width) * Math.Abs(height) / 2.0;
        }
    }
}
