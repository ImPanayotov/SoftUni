using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double hall = (L * 100) * (W * 100);
            double wardrobe = (A * 100) * (A * 100);
            double bench = hall / 10;
            double free = hall - wardrobe - bench;
            double dancers = free / (7000 + 40);
            Console.WriteLine($"{Math.Floor(dancers)}");
        }
    }
}
