using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                left += sum;
            }
            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                right += sum;
            }

            if (left == right)
            {
                //Console.WriteLine("Yes, sum = {0}", left); 
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                //Console.WriteLine("No, diff = {0}", Math.Abs(left - right));
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}
