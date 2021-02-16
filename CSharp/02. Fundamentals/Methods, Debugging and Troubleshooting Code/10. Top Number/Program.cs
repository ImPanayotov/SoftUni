using System;
using System.Globalization;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintMasterNumbers(input);
        }
        public static void PrintMasterNumbers(int input)
        {
            for (int i = 1; i < input; i++)
            {
                int sum = 0;
                int oddCounter = 0;
                int digit = 0;
                int num = i;

                while (num != 0)
                {
                    digit = num % 10;
                    sum += num % 10;
                    num /= 10;
                    if (digit % 2 != 0)
                    {
                        oddCounter++;
                    }
                }
                if (sum % 8 == 0 && oddCounter > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
