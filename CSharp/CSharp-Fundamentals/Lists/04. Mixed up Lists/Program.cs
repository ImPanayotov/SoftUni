using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace _04._Mixed_up_Lists
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
                 .Reverse()
                 .Select(int.Parse)
                 .ToList();


            List<int> result = new List<int>();

            int start = 0;
            int end = 0;

            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count > second.Count)
            {
                if (first[first.Count - 2] >= first[first.Count - 1])
                {
                    start = first[first.Count - 1];
                    end = first[first.Count - 2];
                }
                else
                {
                    start = first[first.Count - 2];
                    end = first[first.Count - 1];
                }
            }
            else
            {
                if (second[second.Count - 2] >= second[second.Count - 1])
                {
                    start = second[second.Count - 1];
                    end = second[second.Count - 2];
                }
                else
                {
                    start = second[second.Count - 2];
                    end = second[second.Count - 1];
                }
            }

            List<int> newResult = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > start && result[i] < end)
                {
                    newResult.Add(result[i]);
                }
            }
            newResult.Sort();

            foreach (var item in newResult)
            {
                Console.Write(item + " ");
            }
        }
    }
}
