using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            DivideAndPrint(a, b);
        }
        public static double FactorialA(double a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * FactorialA(a - 1);
            }
        }

        public static double FactorialB(double b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return b * FactorialA(b - 1);
            }
        }

        public static void DivideAndPrint(double a, double b)
        {
            double result = FactorialA(a) / FactorialB(b);
            Console.WriteLine($"{result:f2}");
        }
    }
}
