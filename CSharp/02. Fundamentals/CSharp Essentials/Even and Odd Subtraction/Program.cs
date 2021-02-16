using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (current % 2 == 0)
                {
                    even += current;
                }
                if (current % 2 != 0)
                {
                    odd += current;
                }
            }
            Console.WriteLine(even - odd);
        }
    }
}
