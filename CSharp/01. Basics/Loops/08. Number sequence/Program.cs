using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // n na broi chisla
            //
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < min)
                {
                    min = value;
                }

                if (value > max)
                {
                    max = value;
                }
            }
            Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");
        }
    }
}
