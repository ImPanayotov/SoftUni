using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value % 2 == 0)
                {
                    countFirst++;
                }
                if (value % 3 == 0)
                {
                    countSecond++;
                }
                if (value % 4 == 0)
                {
                    countThird++;
                }
            }
            double p1 = countFirst * 1.0 / n * 100;
            double p2 = countSecond * 1.0 / n * 100;
            double p3 = countThird * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
