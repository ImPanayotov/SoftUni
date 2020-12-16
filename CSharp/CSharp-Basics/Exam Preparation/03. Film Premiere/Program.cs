using System;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string package = Console.ReadLine();
            int ticketsNumber = int.Parse(Console.ReadLine());
            double price = 0;
            

            switch (title)
            {
                case "John Wick":
                    if (package == "Drink")
                    {
                        price = 12;
                    }
                    else if (package == "Popcorn")
                    {
                        price = 15;
                    }
                    else if (package == "Menu")
                    {
                        price = 19;
                    }
                    break;
                case "Star Wars":
                    if (package == "Drink")
                    {
                        price = 18;
                    }
                    else if (package == "Popcorn")
                    {
                        price = 25;
                    }
                    else if (package == "Menu")
                    {
                        price = 30;
                    }
                    break;
                case "Jumanji":
                    if (package == "Drink")
                    {
                        price = 9;
                    }
                    else if (package == "Popcorn")
                    {
                        price = 11;
                    }
                    else if (package == "Menu")
                    {
                        price = 14;
                    }
                    break;
            }
                    if (title == "Star Wars" && ticketsNumber >= 4)
                    {

                        double totalPrice = price * ticketsNumber * 0.7;
                        Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                    }
                    else if (title == "Jumanji" && ticketsNumber == 2)
                    {
                        double totalPrice = price * ticketsNumber * 0.85;
                        Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                    }
                    else
                    {
                        double totalPrice = price * ticketsNumber;
                        Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                    }
            
        
        }
    }
}
