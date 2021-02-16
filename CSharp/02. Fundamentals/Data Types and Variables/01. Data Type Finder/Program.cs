using System;
using System.IO;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                    continue;
                }
                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                    continue;
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                    continue;
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                    continue;
                }
                else 
                {
                    Console.WriteLine($"{input} is string type");
                    continue;
                }
            }
        }
    }
}
