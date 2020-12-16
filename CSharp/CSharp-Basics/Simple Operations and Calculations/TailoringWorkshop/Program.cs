using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double areaCover = (length + 2 * 0.30) * (width + 2 * 0.30);
            double areaSquare = (length / 2) * (length / 2);
            double dollars = (areaCover * 7 + areaSquare * 9) * tables;
            double BGN = dollars * 1.85;

            Console.WriteLine($"{dollars:f2} USD");
            Console.WriteLine($"{BGN:f2} BGN");
        }
    }
}
