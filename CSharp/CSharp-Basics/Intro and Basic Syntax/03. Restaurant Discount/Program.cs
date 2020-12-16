using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double packagePrice = 0;
            double packageDiscount = 0;
            string hall = "";
            double hallPrice = 0;

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
                switch (package)
                {
                    case "Normal":
                        packagePrice = 500;
                        packageDiscount = 5;
                        break;
                    case "Gold":
                        packagePrice = 750;
                        packageDiscount = 10;
                        break;
                    case "Platinum":
                        packagePrice = 1000;
                        packageDiscount = 15;
                        break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
                switch (package)
                {
                    case "Normal":
                        packagePrice = 500;
                        packageDiscount = 5;
                        break;
                    case "Gold":
                        packagePrice = 750;
                        packageDiscount = 10;
                        break;
                    case "Platinum":
                        packagePrice = 1000;
                        packageDiscount = 15;
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
                switch (package)
                {
                    case "Normal":
                        packagePrice = 500;
                        packageDiscount = 5;
                        break;
                    case "Gold":
                        packagePrice = 750;
                        packageDiscount = 10;
                        break;
                    case "Platinum":
                        packagePrice = 1000;
                        packageDiscount = 15;
                        break;
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an approrpiate hall.");
                return;
            }
            double hallAndPackagePrice = hallPrice + packagePrice;
            double totalWithDiscount = hallAndPackagePrice - (hallAndPackagePrice * packageDiscount / 100);
            double perPersonPrice = totalWithDiscount / groupSize;
            Console.WriteLine($"We can offer you the {hall} ");
            Console.WriteLine($"The price per person is {perPersonPrice:f2}$");
        }
    }
}
