using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;
                while (budget > sum)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                    money++;
                }


                Console.WriteLine($"Going to {country}!");
            }

        }
    }
}
