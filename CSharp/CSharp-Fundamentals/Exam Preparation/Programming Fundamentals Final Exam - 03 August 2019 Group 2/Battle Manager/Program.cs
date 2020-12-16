using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, List<int>>> people =
                new Dictionary<string, Dictionary<string, List<int>>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];

                if (command == "Results")
                {
                    break;
                }

                if (command == "Add")
                {
                    string name = input[1];
                    int health = int.Parse(input[2]);
                    int energy = int.Parse(input[3]);
                    if (health >= 1 && health <= 100000 && energy >= 1 && energy <= 100)
                    {
                        if (!people.ContainsKey(name))
                        {
                            people.Add(name, new Dictionary<string, List<int>>());

                            people[name].Add("Health", new List<int>());
                            people[name]["Health"].Add(health);

                            people[name].Add("Energy", new List<int>());
                            people[name]["Energy"].Add(energy);
                        }
                        else
                        {
                            people[name]["Health"][0] += health;
                            
                        }
                    }
                }
                else if (command == "Attack")
                {
                    string attacker = input[1];
                    string defender = input[2];
                    int damage = int.Parse(input[3]);

                    if (people.ContainsKey(attacker) && people.ContainsKey(defender) && attacker != defender)
                    {
                        people[defender]["Health"][0] -= damage;
                        if (people[defender]["Health"][0] <= 0)
                        {
                            people.Remove(defender);

                            Console.WriteLine($"{defender} was disqualified!");
                        }

                        people[attacker]["Energy"][0] -= 1;
                        if (people[attacker]["Energy"][0] <= 0)
                        {
                            people.Remove(attacker);

                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }
                }
                else if (command == "Delete")
                {
                    string name = input[1];

                    if (people.ContainsKey(name))
                    {
                        people.Remove(name);
                    }
                    else if (name == "All")
                    {
                        people.Clear();
                    }
                }
            }

            Console.WriteLine($"People count: {people.Count}");

            if (people.Count > 0)
            {
                foreach (var person in people
                    .OrderByDescending(x => x.Value["Health"][0])
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{person.Key} - {person.Value["Health"][0]} - {person.Value["Energy"][0]}");
                }
            }
        }
    }
}
