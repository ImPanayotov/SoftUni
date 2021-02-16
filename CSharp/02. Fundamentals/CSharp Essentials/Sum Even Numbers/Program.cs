using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (current % 2 == 0)
                {
                    sum += current;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
