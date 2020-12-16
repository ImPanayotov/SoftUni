using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                if (input[2] == "going!")
                {
                    if (names.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(input[0]);
                    }
                }

                if (input[2] == "not")
                {
                    if (names.Contains(input[0]))
                    {
                        names.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
