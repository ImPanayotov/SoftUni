using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string lenght = number.ToString();
            int sum = 0;

            for (int digitsCount = 0; digitsCount < lenght.Length; digitsCount++)
            {
                int currentFactorial = (int)(lenght.ToString()[digitsCount]) - 48;
                int currentSum = 1;

                for (int count = currentFactorial; count >= 1; count--)
                {
                    currentSum *= count;
                }
                sum = sum + currentSum;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
