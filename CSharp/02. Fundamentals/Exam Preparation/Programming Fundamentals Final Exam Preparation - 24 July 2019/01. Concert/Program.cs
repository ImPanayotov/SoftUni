using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> bands =
                new Dictionary<string, Dictionary<string, List<string>>>();

            Dictionary<string, int> timePlayed = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("; ").ToArray();
                
                string cmd = input[0];

                if (cmd == "start of concert")
                {
                    Console.WriteLine($"Total time: {timePlayed.Values.Sum()}");

                    foreach (var group in timePlayed
                        .OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"{group.Key} -> {group.Value}");
                    }
                    break;
                }

                string bandName = input[1];

                if (cmd == "Add")
                {
                    if (!bands.ContainsKey(bandName))
                    {
                        bands.Add(bandName, new Dictionary<string, List<string>>());
                        bands[bandName].Add("Members", new List<string>());
                    }

                    string[] members = input[2].Split(", ").ToArray();

                    for (int i = 0; i < members.Length; i++)
                    {
                        if (!bands[bandName]["Members"].Contains(members[i]))
                        {
                            bands[bandName]["Members"].Add(members[i]);
                        }
                    }
                }
                else if (cmd == "Play")
                {
                    int time = int.Parse(input[2]);

                    if (!timePlayed.ContainsKey(bandName))
                    {
                        timePlayed.Add(bandName, time);
                    }
                    else
                    {
                        timePlayed[bandName] += time;
                    }
                }
            }

            string band = Console.ReadLine();

            if (bands.ContainsKey(band))
            {
                Console.WriteLine($"{band}");

                foreach (var kvp in bands[band]["Members"])
                {
                    Console.WriteLine($"=> {kvp}");
                }
            }
        }
    }
}
