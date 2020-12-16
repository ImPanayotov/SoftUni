using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSumOfEvenAndOdds(number));
        }

        private static int GetSumOfEvenAndOdds(int number)
        {
            int sumOfEvens = GetSumOfEvenDigits(number);
            int sumOfOdds = GetSumOfOddDigits(number);
            return sumOfEvens * sumOfOdds;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                number /= 10;
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdd += lastDigit;
                }
                number /= 10;
            }
            return sumOdd;
        }
    }
}
