using System;

namespace _00._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double volume = 0;
            int counter = 0;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    break;
                }
                volume = double.Parse(input);

                if (counter % 2 == 0 && counter != 0)
                {
                    volume = volume + (volume * 0.1);
                }
                if (capacity < volume)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                counter++;
                capacity -= volume;
            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
