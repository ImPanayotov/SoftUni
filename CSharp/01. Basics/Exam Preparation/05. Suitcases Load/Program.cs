using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            int suitCases = 0;
            double volume = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                volume = double.Parse(input);
                for (double i = capacity; i <= 0; i -= volume)
                {
                    if (capacity <= 0)
                    {
                        suitCases--;
                        Console.WriteLine("No more space!");
                        Console.WriteLine($"Statistic: {suitCases} suitcases loaded.");
                    }
                    else if (suitCases % 3 == 0)
                    {
                        volume = double.Parse(input) * 1.1;
                    }
                }
            }
                

                
                
            
            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitCases} suitcases loaded.");
        }
    }
}
