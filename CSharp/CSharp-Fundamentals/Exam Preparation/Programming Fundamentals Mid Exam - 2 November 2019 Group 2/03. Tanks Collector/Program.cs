using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanks = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ").ToArray();

                if (command[0] == "Add")
                {
                    string tankName = command[1];
                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        tanks.Add(tankName);
                    }
                }
                else if (command[0] == "Remove")
                {
                    string tankName = command[1];

                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully sold");
                        tanks.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < tanks.Count)
                    {
                        Console.WriteLine("Tank successfully sold");
                        tanks.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string tankName = command[2];

                    if (index >= 0 && index < tanks.Count)
                    {
                        if (tanks.Contains(tankName))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank successfully bought");
                            tanks.Insert(index, tankName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", tanks));
        }
    }
}
