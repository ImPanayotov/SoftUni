using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int count = 0;

            if (first.Count > second.Count)
            {
                count = first.Count;
            }
            else
            {
                count = second.Count;
            }

            for (int i = 0; i < count; i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
