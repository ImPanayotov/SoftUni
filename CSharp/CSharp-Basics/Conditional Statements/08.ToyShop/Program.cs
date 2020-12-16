using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzles * 2.60 + dolls * 3 + teddies * 4.10 + minions * 8.20 + trucks * 2;
            

            int numOfToys = puzzles + dolls + teddies + minions + trucks;

            if (numOfToys >= 50)
            {
                total = total - total * 0.25;
                
            }

            total = total - total * 0.10;

            if (total >= vacationPrice)
            {
                Console.WriteLine($"Yes! {total - vacationPrice:f2} lv left.");
            }
                else
            {
                Console.WriteLine($"Not enough money! {vacationPrice - total:f2} lv needed.");
            }
        }
    }
}
