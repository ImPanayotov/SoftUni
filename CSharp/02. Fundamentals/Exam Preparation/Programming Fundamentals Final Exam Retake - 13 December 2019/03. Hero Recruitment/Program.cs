using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes =
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string cmd = input[0];

                if (cmd == "End")
                {
                    break;
                }

                if (cmd == "Enroll")
                {
                    string name = input[1];

                    if (!heroes.ContainsKey(name))
                    {
                        heroes.Add(name, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                }
                else if (cmd == "Learn")
                {
                    string name = input[1];
                    string spell = input[2];

                    if (!heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                        continue;
                    }

                    if (heroes[name].Contains(spell))
                    {
                        Console.WriteLine($"{name} has already learnt {spell}.");
                    }
                    else
                    {
                        heroes[name].Add(spell);
                    }
                }
                else if (cmd == "Unlearn")
                {
                    string name = input[1];
                    string spell = input[2];

                    if (!heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                        continue;
                    }

                    if (!heroes[name].Contains(spell))
                    {
                        Console.WriteLine($"{name} doesn't know {spell}.");
                    }
                    else
                    {
                        heroes[name].Remove(spell);
                    }
                }
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.Write($"== {hero.Key}: ");
                Console.WriteLine(string.Join(", ", hero.Value));
            }
        }
    }
}
