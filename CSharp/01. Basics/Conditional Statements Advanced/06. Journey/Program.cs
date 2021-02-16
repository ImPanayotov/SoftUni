using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // summer or winter

            string destination = "";
            string placeToStay = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                placeToStay = "Hotel";
                price = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {price:f2}");


        }
    }
}
