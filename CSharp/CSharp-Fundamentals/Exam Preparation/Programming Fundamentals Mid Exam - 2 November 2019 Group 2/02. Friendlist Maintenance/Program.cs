using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int countBlack = 0;
            int countLost = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Report" )
                {
                    break;
                }

                if (input[0] == "Blacklist")
                {
                    if (names.Contains(input[1]))
                    {
                        int index = names.IndexOf(input[1]);
                        Console.WriteLine($"{names[index]} was blacklisted.");
                        names[index] = "Blacklisted";
                        countBlack++;
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} was not found.");
                    }
                }
                else if (input[0] == "Error")
                {
                    int index = int.Parse(input[1]);

                    if ((names[index] != "Blacklisted") && (names[index] != "Lost"))
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names[index] = "Lost";
                        countLost++;
                    }
                }
                else if (input[0] == "Change")
                {
                    int index = int.Parse(input[1]);

                    if (index >= 0 && index < names.Count)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {input[2]}.");
                        names[index] = input[2];
                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {countBlack}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
