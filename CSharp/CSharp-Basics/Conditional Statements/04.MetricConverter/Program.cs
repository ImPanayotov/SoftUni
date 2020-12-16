using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double numerConvertedToMeter = 0.0;
            double result = 0.0;


            if (input == "cm")
            {
                numerConvertedToMeter = 0.01 * number;

            }
            else if (input == "mm")
            {
                numerConvertedToMeter = 0.001 * number;
            }

            else if (input == "m")
            {
                numerConvertedToMeter = number;
            }

            if (output == "cm")
            {
                result = numerConvertedToMeter * 100;
                Console.WriteLine($"{result:F3}");
            }
            else if (output == "mm")
            {
                result = numerConvertedToMeter * 1000;
                Console.WriteLine($"{result:F3}");
            }
            else
            {
                Console.WriteLine($"{numerConvertedToMeter:F3}");
            }


        }
    }
    
}
