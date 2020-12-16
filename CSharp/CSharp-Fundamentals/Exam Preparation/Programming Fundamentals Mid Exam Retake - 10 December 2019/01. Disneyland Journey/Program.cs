using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal journeyCost = decimal.Parse(Console.ReadLine());
            int numOfMonths = int.Parse(Console.ReadLine());
            decimal savings = 0.0m;

            for (int i = 1; i <= numOfMonths; i++)
            {
                
                if (i != 1 && i % 2 != 0 )
                {
                    savings *= 0.84m;
                }

                if (i % 4 == 0)
                {
                    savings *= 1.25m;
                }

                savings += journeyCost / 4;
            }

            if (savings >= journeyCost)
            {
                decimal souvenirs = savings - journeyCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {souvenirs:f2}lv. for souvenirs.");
            }
            else
            {
                decimal neededMoney = journeyCost - savings;
                Console.WriteLine($"Sorry. You need {neededMoney:f2}lv. more.");
            }

        }
    }
}
