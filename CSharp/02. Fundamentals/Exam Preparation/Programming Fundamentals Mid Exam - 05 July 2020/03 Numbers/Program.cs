using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double average = numbers.Average();

            List<int> topNums = new List<int>();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    topNums.Add(numbers[i]);
                }
            }

            int[] result = topNums.OrderByDescending(x => x).ToArray();

            if (topNums.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (result.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(result[i] + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
