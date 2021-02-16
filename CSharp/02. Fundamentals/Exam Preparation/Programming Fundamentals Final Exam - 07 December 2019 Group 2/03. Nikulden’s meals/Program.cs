using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests =
                new Dictionary<string, List<string>>();

            int unlikedMeals = 0;

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                string cmd = input[0];

                if (cmd == "Stop")
                {
                    break;
                }

                if (cmd == "Like")
                {
                    string guest = input[1];
                    string meal = input[2];

                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                    }

                    if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }
                }
                else if (cmd == "Unlike")
                {
                    string guest = input[1];
                    string meal = input[2];

                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            unlikedMeals++;
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
            }

            foreach (var guest in guests
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.Write($"{guest.Key}: " + string.Join(", ", guest.Value));
                Console.WriteLine();
            }

            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
