using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumAll = 0;
            int max = int.MinValue;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());

                sumAll += value;

                if (value > max)
                {
                    max = value;
                }
            }
            int sumOfOther = sumAll - max;
            if (sumOfOther == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - sumOfOther));
            }
        }
    }
}
