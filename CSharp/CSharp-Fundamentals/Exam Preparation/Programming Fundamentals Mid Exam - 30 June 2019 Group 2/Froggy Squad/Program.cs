using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "Print")
                {
                    if (input[1] == "Normal")
                    {
                        Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                    }
                    else if (input[1] == "Reversed")
                    {
                        frogNames.Reverse();
                        Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                    }
                    break;
                }

                if (command == "Join")
                {
                    string name = input[1];
                    if (!frogNames.Contains(name))
                    {
                        Join(frogNames, name);
                    }
                }
                else if (command == "Jump")
                {
                    string name = input[1];
                    int index = int.Parse(input[2]);
                    Jump(frogNames, index, name);
                }
                else if (command == "Dive")
                {
                    int index = int.Parse(input[1]);
                    Dive(frogNames, index);
                }
                else if (command == "First")
                {
                    int count = int.Parse(input[1]);
                    PrintFirst(frogNames, count);
                }
                else if (command == "Last")
                {
                    int count = int.Parse(input[1]);
                    PrintLast(frogNames, count);
                }
            }
        }

        public static List<string> Join(List<string> frogNames, string name)
        {
            frogNames.Add(name);
            return frogNames;
        }

        public static List<string> Jump(List<string> frogNames, int index, string name)
        {
            if (index >= 0 && index < frogNames.Count)
            {
                frogNames.Insert(index, name);
            }

            return frogNames;
        }

        public static List<string> Dive(List<string> frogNames, int index)
        {
            if (index >= 0 && index < frogNames.Count)
            {
                frogNames.RemoveAt(index);
            }

            return frogNames;
        }

        public static void PrintFirst(List<string> frogNames, int count)
        {
            if (count >= frogNames.Count)
            {
                count = frogNames.Count;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(frogNames[i] + " ");
            }

            Console.WriteLine();
        }

        public static void PrintLast(List<string> frogNames, int count)
        {
            if (count >= frogNames.Count)
            {
                count = frogNames.Count;
            }

            for (int i = frogNames.Count - count; i < frogNames.Count; i++)
            {
                Console.Write(frogNames[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
