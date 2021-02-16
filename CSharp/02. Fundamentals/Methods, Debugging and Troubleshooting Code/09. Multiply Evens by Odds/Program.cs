using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenesAndOdds(n);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenesAndOdds(int n)
        {
            int sumEvans = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvans * sumOdds;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = (n % 10);
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = (n % 10);
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

    }
}
