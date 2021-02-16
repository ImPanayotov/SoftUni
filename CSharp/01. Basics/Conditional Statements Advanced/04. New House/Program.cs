using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double singlePrice = 0;

            switch (flowerType)
            {
                case "Roses":
                    singlePrice = 5;
                    break;
                case "Dahlias":
                    singlePrice = 3.80;
                    break;
                case "Tulips":
                    singlePrice = 2.80;
                    break;
                case "Narcissus":
                    singlePrice = 3;
                    break;
                case "Gladiolus":
                    singlePrice = 2.50;
                    break;

            }

            double totalPrice = flowerCount * singlePrice;
            
            if (flowerCount > 80 && flowerType == "Roses")
            {
                totalPrice = totalPrice * 0.9;
            }
            else if (flowerCount > 90 && flowerType == "Dahlias")
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (flowerCount > 80 && flowerType == "Tulips")
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (flowerCount < 120 && flowerType == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if (flowerCount < 80 && flowerType == "Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }



        }
    }
}
