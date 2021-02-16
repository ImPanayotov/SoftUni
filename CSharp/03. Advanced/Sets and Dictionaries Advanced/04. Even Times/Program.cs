using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(input))
                {
                    numbers[input] += 1;
                }
                else
                {
                    numbers.Add(input, 1);
                }
            }

            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    return;
                }
            }
        }
    }
}
