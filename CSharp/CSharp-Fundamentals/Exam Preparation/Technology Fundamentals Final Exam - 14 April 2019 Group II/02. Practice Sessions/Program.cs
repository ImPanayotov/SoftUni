using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roads =
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->").ToArray();

                string cmd = input[0];

                if (cmd == "END")
                {
                    break;
                }

                if (cmd == "Add")
                {
                    string road = input[1];
                    string racer = input[2];

                    if (!roads.ContainsKey(road))
                    {
                        roads.Add(road, new List<string>());
                    }

                    roads[road].Add(racer);
                }
                else if (cmd == "Move")
                {
                    string current = input[1];
                    string next = input[3];
                    string racer = input[2];

                    if (roads[current].Contains(racer))
                    {
                        roads[next].Add(racer);
                        roads[current].Remove(racer);
                    }
                }
                else if (cmd == "Close")
                {
                    string road = input[1];

                    if (roads.ContainsKey(road))
                    {
                        roads.Remove(road);
                    }
                }
            }

            Console.WriteLine("Practice sessions:");

            foreach (var road in roads
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine(road.Key);

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }

        }
    }
}
