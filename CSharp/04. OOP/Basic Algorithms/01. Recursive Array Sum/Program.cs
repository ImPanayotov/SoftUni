using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(GetSum(nums, 0));
        }

        public static int GetSum(int[] nums, int index)
        {
            if (index == nums.Length - 1)
            {
                return nums[index];
            }

            return nums[index] + GetSum(nums, index + 1);
        }
    }
}
