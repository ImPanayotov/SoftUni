using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{ area:f3}");
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = (r * r) * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
