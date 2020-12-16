using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] a2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            double sum = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
                
            }
            sum = a1.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            
        }
    }
}
