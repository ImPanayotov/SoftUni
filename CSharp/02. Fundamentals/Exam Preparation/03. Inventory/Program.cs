using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Craft!")
                {
                    Console.WriteLine(string.Join(", ", journal));
                    break;
                }

                string[] commands = input.Split(" - ");

                if (commands[0] == "Collect")
                {
                    if (!journal.Contains(commands[1]))
                    {
                        journal.Add(commands[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Drop")
                {
                    if (journal.Contains(commands[1]))
                    {
                        journal.Remove(commands[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Combine Items")
                {
                    string[] items = commands[1].Split(":");
                    if (journal.Contains(items[0]))
                    {
                        int index = journal.IndexOf(items[0]);
                        journal.Insert(index + 1, items[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Renew")
                {
                    if (journal.Contains(commands[1]))
                    {
                        journal.Remove(commands[1]);
                        journal.Add(commands[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
