using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int counter = 0;
            while (isRunning)
            {
                string input = Console.ReadLine();

                if (input == "Bake!")
                {
                    isRunning = false;
                    
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                    counter++;
                }
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
