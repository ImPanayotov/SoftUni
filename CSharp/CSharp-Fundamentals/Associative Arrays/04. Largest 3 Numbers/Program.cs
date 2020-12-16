using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .OrderByDescending(x => x)
                .ToList();

            for (int i = 0; i < (numbers.Count < 3? numbers.Count:3); i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
