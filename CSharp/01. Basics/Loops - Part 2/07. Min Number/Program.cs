using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < min)
                {
                    min = current;

                }

            }
            Console.WriteLine(min);
        }
    }
}
