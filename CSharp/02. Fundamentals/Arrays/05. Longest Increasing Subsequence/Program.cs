using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] index = new int[nums.Length];

            int bestIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && index[j] > index[i] - 1)
                    {
                        index[i] = index[j] + 1;

                        if (index[i] > index[bestIndex])
                        {
                            bestIndex = i;
                        }
                    }
                }
            }

            Print(bestIndex, nums, index);
        }

        public static void Print(int bestIndex, int[] nums, int[] index)
        {
            bool isFirst = true;

            for (int i = 0; i < bestIndex; i++)
            {
                if (nums[i] < nums[bestIndex] && index[i] == index[bestIndex] - 1 && isFirst)
                {
                    isFirst = false;
                    Print(i, nums, index);
                }
            }

            Console.Write(nums[bestIndex] + " ");
        }
    }
}
