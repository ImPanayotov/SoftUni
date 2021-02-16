using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string command = input[0];

                if (command == "End")
                {
                    Console.WriteLine(string.Join("|", targets));
                    break;
                }

                if (command == "Shoot")
                {
                    int index = int.Parse(input[1]);
                    int power = int.Parse(input[2]);

                    Shoot(targets, index, power);
                }
                else if (command == "Add")
                {
                    int index = int.Parse(input[1]);
                    int value = int.Parse(input[2]);

                    Add(targets, index, value);
                }
                else if (command == "Strike")
                {
                    int index = int.Parse(input[1]);
                    int radius = int.Parse(input[2]);

                    Strike(targets, index, radius);
                }
            }
        }

        private static List<int> Shoot(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (targets[index] > 0)
                {
                    targets[index] -= power;

                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }
            }

            return targets;
        }

        private static List<int> Add(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }

            return targets;
        }

        private static List<int> Strike(List<int> targets, int index, int radius)
        {
            if (index + radius < targets.Count && index - radius >= 0)
            {
                targets.RemoveRange(index - radius, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }

            return targets;
        }
    }
}
