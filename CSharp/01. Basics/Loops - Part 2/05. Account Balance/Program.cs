using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            while (input > counter)
            {
                counter++;
                    double income = double.Parse(Console.ReadLine());
                if (income <0)

                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += income;
                Console.WriteLine($"Increase: {income:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
