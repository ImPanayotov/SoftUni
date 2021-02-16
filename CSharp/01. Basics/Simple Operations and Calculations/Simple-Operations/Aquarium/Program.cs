using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;

            double totalLiters = (volume * 1.0) / 1000;
            double liters = totalLiters - (percent / 100) * totalLiters;
            Console.WriteLine($"{liters:f3}");
        }
    }
}
