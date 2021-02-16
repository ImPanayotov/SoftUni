using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            bool isPrime = true;
            int sumPrime = 0;
            int sumNonPrime = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                isPrime = true;
                int currentNum = int.Parse(input);
                if (currentNum <0 )
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(currentNum); i++)
                {
                    if (currentNum % i == 0)
                    {
                        
                        sumNonPrime += currentNum;
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += currentNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
