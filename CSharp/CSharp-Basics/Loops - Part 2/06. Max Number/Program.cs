using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > max)
                {
                    max = current;

                }
                
            }
            Console.WriteLine(max);
        }
    }
}
