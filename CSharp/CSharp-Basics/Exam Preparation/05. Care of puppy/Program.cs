using System;

namespace _05._Care_of_puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgOfFood = int.Parse(Console.ReadLine());
            kgOfFood = kgOfFood * 1000;
            double food = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Adopted")
                {
                    break;
                }
                else
                {
                    food += int.Parse(command);
                }

            }
            if (kgOfFood >= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {kgOfFood - food} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {food - kgOfFood} grams more.");
            }
        }
    }
}
