using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                .Split("|")
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];

                if (command == "Yohoho!")
                {
                    break;
                }

                if (command=="Loot")
                {
                    Loot(initialLoot, input);
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(input[1]);
                    Drop(initialLoot, index);
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(input[1]);
                    Steal(initialLoot, count);
                }
            }

            double sum = 0;

            for (int i = 0; i < initialLoot.Count; i++)
            {
                sum += initialLoot[i].Length;
            }

            double output = sum / initialLoot.Count;
            if (initialLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {output:f2} pirate credits.");
            }
            
        }

        public static List<string> Loot(List<string> initialLoot, string[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                if (!initialLoot.Contains(input[i]))
                {
                    initialLoot.Insert(0, input[i]);
                }
            }

            return initialLoot;
        }

        public static List<string> Drop(List<string> initalLoot, int index)
        {
            if (index >= 0 && index < initalLoot.Count)
            {
                string loot = initalLoot[index];
                initalLoot.Add(loot);
                initalLoot.RemoveAt(index);
            }

            return initalLoot;
        }

        public static List<string> Steal(List<string> initialLoot, int count)
        {
            if (count >= initialLoot.Count)
            {
                count = initialLoot.Count;
            }
            List<string> removed = new List<string>();

            for (int i = initialLoot.Count - count; i < initialLoot.Count; i++)
            {
                removed.Add(initialLoot[i]);
                initialLoot.RemoveAt(i);
                i--;
            }

            Console.WriteLine(string.Join(", ", removed));
            return initialLoot;
        }



    }
}
