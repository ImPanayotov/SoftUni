using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._P_rates
{
    class MappedValue
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, MappedValue> dict =
                new Dictionary<string, MappedValue>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("||").ToArray();

                if (input[0] == "Sail")
                {
                    break;
                }

                string town = input[0];
                int people = int.Parse(input[1]);
                int gold = int.Parse(input[2]);

                if (dict.ContainsKey(town))
                {
                    dict[town].Population += people;
                    dict[town].Gold += gold;
                }
                else
                {
                    dict.Add(town, new MappedValue());
                    dict[town].Population += people;
                    dict[town].Gold += gold;
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("=>").ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string command = input[0];

                if (command == "Plunder")
                {
                    string town = input[1];
                    int people = int.Parse(input[2]);
                    int gold = int.Parse(input[3]);

                    dict[town].Population -= people;
                    dict[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (dict[town].Gold <= 0 || dict[town].Population <= 0)
                    {
                        dict.Remove(town);
                        dict.Remove(town);

                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    string town = input[1];
                    int gold = int.Parse(input[2]);

                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dict[town].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {dict[town].Gold} gold.");
                    }
                }
            }

            if (dict.Count > 0)
            {
                var ordered = dict.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key);

                Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");

                foreach (var item in ordered)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
