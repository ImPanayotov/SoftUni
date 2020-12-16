using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double profit = 0;

            while (input != "Movie time!")
            {
                int countPeople = int.Parse(input);
                capacity -= countPeople;
                if (capacity < 0)
                {
                    break;
                }
                if (countPeople % 3 == 0)
                {
                    profit += (countPeople * 5) - 5;
                }
                else
                {
                    profit += countPeople * 5;
                }
                input = Console.ReadLine();

            }
            if (capacity >= 0)
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }

            Console.WriteLine($"Cinema income - {profit} lv.");
        }
    }
}
