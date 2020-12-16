using System;
using System.Linq;

namespace _06._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int current = 0; current < arr.Length; current++)
            {
                int sumRight = 0;
                for (int i = current; i < arr.Length; i++)
                {
                    sumRight += arr[i];
                }

                int sumLeft = 0;
                for (int i = current; i >= 0; i--)
                {
                    sumLeft += arr[i];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(current);
                    isFound = true;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
