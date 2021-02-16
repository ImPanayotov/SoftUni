using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = w * h;
            Console.WriteLine($"{area:f2}");
        }
    }
}
