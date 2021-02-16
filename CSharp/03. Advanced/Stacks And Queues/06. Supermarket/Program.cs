using System;
using System.Collections;
using System.Collections.Generic;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Paid")
                {
                    foreach (var person in names)
                    {
                        Console.WriteLine(person);
                    }

                    names.Clear();
                    continue;
                }
                else if (input == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }

                names.Enqueue(input);
            }
        }
    }
}
