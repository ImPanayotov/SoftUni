using System;

namespace _15._Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isValid = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isValid = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isValid}");
            }

        }
    }
}
