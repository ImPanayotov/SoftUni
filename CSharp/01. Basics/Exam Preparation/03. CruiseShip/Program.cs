using System;

namespace _03._CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Mediterranean", "Adriatic", "Aegean"
            string cruise = Console.ReadLine();

            //"standard cabin", "cabin with balcony", "apartment"
            string cabinType = Console.ReadLine();

            int nights = int.Parse(Console.ReadLine());


            double price = 0;

            switch (cruise)
            {
                case "Mediterranean":
                    if (cabinType == "standard cabin")
                    {
                        price = nights * 4 * 27.50;
                    }
                    else if (cabinType == "cabin with balcony")
                    {
                        price = nights * 4 * 30.20;
                    }
                    else if (cabinType == "apartment")
                    {
                        price = nights * 4 * 40.50;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                case "Adriatic":
                    if (cabinType == "standard cabin")
                    {
                        price = nights * 4 * 22.99;
                    }
                    else if (cabinType == "cabin with balcony")
                    {
                        price = nights * 4 * 25.00;
                    }
                    else if (cabinType == "apartment")
                    {
                        price = nights * 4 * 34.99;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                case "Aegean":
                    if (cabinType == "standard cabin")
                    {
                        price = nights * 4 * 23.00;
                    }
                    else if (cabinType == "cabin with balcony")
                    {
                        price = nights * 4 * 26.60;
                    }
                    else if (cabinType == "apartment")
                    {
                        price = nights * 4 * 39.80;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid cruise!");
                    break;
            }

            if (nights > 7)
            {
                price = 0.75 * price;
            }

            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {price:F2} lv.");







        }
    }
}
