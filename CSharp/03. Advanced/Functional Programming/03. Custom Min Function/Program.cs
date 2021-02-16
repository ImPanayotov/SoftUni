using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myIntParse = s => int.Parse(s);

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(myIntParse)
                .ToArray();

            Console.WriteLine(GetMin(numbers));
        }

        static int GetMin(int[] nums)
        {
            int minNum = Int32.MaxValue;

            foreach (int num in nums)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            return minNum;
        }
    }
}
