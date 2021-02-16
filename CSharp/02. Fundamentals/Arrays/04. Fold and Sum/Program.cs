using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numsToGet = nums.Length / 4;

            int[] firstFold = nums.Take(numsToGet).ToArray();
            int[] lastFold = nums.TakeLast(numsToGet).ToArray();

            Array.Reverse(firstFold);
            Array.Reverse(lastFold);

            int counter1 = 0;
            for (int i = numsToGet; i < numsToGet * 2; i++)
            {
                Console.Write(nums[i] + firstFold[counter1] + " ");
                counter1++;
            }

            int counter2 = 0;
            for (int i = numsToGet * 2; i < nums.Length - numsToGet; i++)
            {
                Console.Write(nums[i] + lastFold[counter2] + " ");
                counter2++;
            }
        }
    }
}
