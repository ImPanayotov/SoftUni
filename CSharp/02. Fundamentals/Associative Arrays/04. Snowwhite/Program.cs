using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ").ToArray();

                if (input[0] == "Once upon a time")
                {
                    break;
                }

                string color = input[1];
                string name = input[0];
                int physics = int.Parse(input[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs.Add(color, new Dictionary<string, int>());
                    dwarfs[color].Add(name, physics);
                }

                if (dwarfs[color].ContainsKey(name))
                {
                    if (dwarfs[color][name] < physics)
                    {
                        dwarfs[color][name] = physics;
                    }
                }
                else
                {
                    dwarfs[color].Add(name, physics);
                }
            }

          

            //Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();

            //foreach (var color in dwarfs.OrderByDescending(x => x.Value.Count()))
            //{
            //    foreach (var dwarf in color.Value)
            //    {
            //        sortedDwarfs.Add($"({color.Key}) {dwarf.Key} <-> ", dwarf.Value);
            //    }
            //}

            //foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            //{
            //    Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            //}
        }
    }
}
