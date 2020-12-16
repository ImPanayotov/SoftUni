using System;

namespace _05._Kufari
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double count = 0;
            double diff = 1;

            while (input != "End")
            {
                
                if (capacity < 0)
                {
                    break;
                }
                double suitcases = double.Parse(input);
                
                count++;
                if (count % 3 == 0)
                {
                    suitcases = suitcases * 1.1;
                    capacity -= suitcases;
                }
                else if (capacity < suitcases)
                {
                    count--;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {count} suitcases loaded.");
                    break;
                }
                else
                {
                    capacity -= suitcases;
                    
                }
                //capacity -= suitcases;
                input = Console.ReadLine();

            }

            if (capacity >= 0)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    Console.WriteLine($"Statistic: {count} suitcases loaded.");

            }
            else
            {
                Console.WriteLine("No more space!");
                Console.WriteLine($"Statistic: {(count - diff)} suitcases loaded.");
            }

            
        }
    }
}
