using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragons =
                new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string type = input[0];
                string name = input[1];

                int damage = input[2] != "null" ? int.Parse(input[2]) : 45;
                int health = input[3] != "null" ? int.Parse(input[3]) : 250;
                int armor = input[4] != "null" ? int.Parse(input[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new Dictionary<string, int>());
                    dragons[type][name].Add("damage", new int());
                    dragons[type][name].Add("health", new int());
                    dragons[type][name].Add("armor", new int());
                }

                dragons[type][name]["damage"] = damage;
                dragons[type][name]["health"] = health;
                dragons[type][name]["armor"] = armor;
            }

            foreach (var type in dragons)
            {
                double avgDamage = type.Value.Average(x => x.Value["damage"]);
                double avgHealth = type.Value.Average(x => x.Value["health"]);
                double avgArmor = type.Value.Average(x => x.Value["armor"]);

                Console.WriteLine($"{type.Key}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");

                foreach (var name in dragons[type.Key])
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value["damage"]}, health: {name.Value["health"]}, armor: {name.Value["armor"]}");
                }
            }
        }
    }
}
