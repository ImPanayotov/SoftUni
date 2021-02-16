using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double days = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Winter":
                    if (destination == "Dubai")
                    {
                        price = 45000;
                    }
                    else if (destination == "Sofia")
                    {
                        price = 17000;
                    }
                    else if (destination == "London")
                    {
                        price = 24000;
                    }
                    break;

                case "Summer":
                    if (destination == "Dubai")
                    {
                        price = 40000;
                    }
                    else if (destination == "Sofia")
                    {
                        price = 12500;
                    }
                    else if (destination == "London")
                    {
                        price = 20250;
                    }
                    break;
            }
            double total = price * days;
            if (destination == "Dubai")
            {
                double totalPrice = price * days * 0.7;
                if (budget >= totalPrice)
                {
                    Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
                }
                else
                {
                    Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
                }
            }
            else if (destination == "Sofia")
            {
                double totalPrice = price * 1.25 * days;
                if (budget >= totalPrice)
                {
                    Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
                }
                else
                {
                    Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
                }
            }
            else
            {
                double totalPrice = price * days;
                if (budget >= totalPrice)
                {
                    Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
                }
                else
                {
                    Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
                }
            }









        }
    }
}
