using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;
            int countFourth = 0;
            int countFifth = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value < 200)
                {
                    countFirst++;
                }
                else if (value >= 200 && value <= 399)
                {
                    countSecond++;
                }
                else if (value >= 400 && value <= 599)
                {
                    countThird++;
                }
                else if (value >= 600 && value <= 799)
                {
                    countFourth++;
                }
                else
                {
                    countFifth++;
                }
            }
            double p1 = countFirst * 1.0 / n * 100;
            double p2 = countSecond * 1.0 / n * 100;
            double p3 = countThird * 1.0 / n * 100;
            double p4 = countFourth * 1.0 / n * 100;
            double p5 = countFifth * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
