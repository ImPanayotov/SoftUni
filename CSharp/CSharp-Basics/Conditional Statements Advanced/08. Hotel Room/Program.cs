using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartamentPrice = 65;

                if (numOfNights > 7 && numOfNights <= 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
                else if (numOfNights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.3;
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.1;
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.2;
                apartamentPrice = 68.7;

                if (numOfNights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.2;
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartamentPrice = 77;

                if (numOfNights > 14)
                {
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.1;
                }
            }


            Console.WriteLine($"Apartment: {(apartamentPrice * numOfNights):F2} lv.");
            Console.WriteLine($"Studio: {(studioPrice * numOfNights):F2} lv.");

        }
    }
}
