using System;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n == 1)
            {
                double num = double.Parse(Console.ReadLine());

                Console.WriteLine($"OddSum={num:F2},");
                Console.WriteLine($"OddMin={num:F2},");
                Console.WriteLine($"OddMax={num:F2},");

                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 0)
            {

                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");

                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int number = 1; number <= n; number++)
                {
                    double value = double.Parse(Console.ReadLine());

                    if (number % 2 != 0)
                    {
                        oddSum += value;
                        if (value < oddMin)
                        {
                            oddMin = value;
                        }
                        if (value > oddMax)
                        {
                            oddMax = value;
                        }

                    }
                    if (number % 2 == 0)
                    {
                        evenSum += value;
                        if (value < evenMin)
                        {
                            evenMin = value;
                        }
                        if (value > evenMax)
                        {
                            evenMax = value;
                        }

                    }
                }

                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
