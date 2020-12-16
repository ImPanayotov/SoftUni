using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ")
                .Select(ParseNum)
                .ToArray();

            PrintResults(array, GetCount, x =>
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                }

                return sum;
            });
        }

        static int GetCount(int[] array)
        {
            return array.Length;
        }

        static int GetSUm(int[] array)
        {
            return array.Sum();
        }

        static void PrintResults(int[] array, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int ParseNum(string num)
        {
            return int.Parse(num);
        }
    }
}
