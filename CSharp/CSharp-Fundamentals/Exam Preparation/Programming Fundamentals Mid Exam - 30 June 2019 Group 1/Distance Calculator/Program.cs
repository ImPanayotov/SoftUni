using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int distance = 100 * int.Parse(Console.ReadLine());

            double totalSteps = lenght * ((steps / 5 * 0.7) + steps - (steps / 5));
            double percent = totalSteps / distance * 100;
            Console.WriteLine($"You travelled {percent:f2}% of the distance!");
        }
    }
}
