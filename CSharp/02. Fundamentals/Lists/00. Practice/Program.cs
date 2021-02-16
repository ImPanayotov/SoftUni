using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine().Split().Select(int.Parse).ToList();
            foreach (var item in times)
            {
                Console.Write(item + " ");
            }
            times.Reverse();
            foreach (var item in times)
            {
                Console.Write(item + " ");
            }

        }
    }
}
