using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double price = 0;


            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }


            if (season == "Spring")
            {
                if (people <= 6)
                {
                    price = price * 0.9;
                }
                else if (people <= 11)
                {
                    price = price * 0.85;
                }
                else if (people >= 12)
                {
                    price = price * 0.75;
                }

            }
            if (season == "Summer" || season == "Autumn")
            {
                if (people <= 6)
                {
                    price = price * 0.9;
                }
                else if (people <= 11)
                {
                    price = price * 0.85;
                }
                else if (people >= 12)
                {
                    price = price * 0.75;
                }


            }
            if (season == "Winter")
            {
                if (people <= 6)
                {
                    price = price * 0.9;
                }
                else if (people <= 11)
                {
                    price = price * 0.85;
                }
                else if (people >= 12)
                {
                    price = price * 0.75;
                }


            }
            if ((season == "Spring" || season == "Summer" || season == "Winter") && people % 2 == 0)
            {
                price = price * 0.95;
            }



            if (price <= budget)
            {

                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }
        }
    }
}
