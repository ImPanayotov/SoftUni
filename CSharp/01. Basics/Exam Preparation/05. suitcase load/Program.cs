using System;

namespace _05._suitcase_load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            double count = 0;
            
            count = 0;

            while (command != "End")
            {
                double suitcase = double.Parse(Console.ReadLine());
                capacity -= suitcase;
                if (command == "End")
                {
                    if (capacity >= 0)
                    {
                        Console.WriteLine($"Congratulations! All suitcases are loaded!");
                        Console.WriteLine($"Statistic: {count} suitcases loaded.");
                    }

                    break;
                }


                if (capacity < 0)
                {
                    Console.WriteLine($"No more space!");
                    Console.WriteLine($"Statistic: {count} suitcases loaded.");

                    break;
                }
                else
                {
                    capacity -= suitcase;
                    count++;
                }

                if (capacity >= 0)
                {
                    capacity -= suitcase;
                    count++;
                }
                if (count % 3 == 0)
                {
                    suitcase = suitcase * 1.1;
                }

                else if (capacity <= suitcase)
                {
                    Console.WriteLine($"No more space!");
                    Console.WriteLine($"Statistic: {count} suitcases loaded.");



                }
            }


        }
    }
}
