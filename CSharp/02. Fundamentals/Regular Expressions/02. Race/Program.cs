using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new
                Regex(@"(?<name>[A-Za-z]*)(?<digits>[0-9]{1})?");

            Dictionary<string, int> racers = new Dictionary<string, int>();

            string[] participants = Console.ReadLine().Split(", ").ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                if (!regex.IsMatch(input))
                {
                    continue;
                }

                MatchCollection matches = regex.Matches(input);

                string name = string.Empty;
                int distance = 0;

                for (int i = 0; i < matches.Count; i++)
                {
                    name += (matches[i].Groups["name"].Value);

                    if (Int32.TryParse(matches[i].Groups["digits"].Value, out _))
                    {
                        distance += int.Parse(matches[i].Groups["digits"].Value);
                    }
                }

                if (participants.Contains(name))
                {
                    if (!racers.ContainsKey(name))
                    {
                        racers.Add(name, distance);
                    }
                    else
                    {
                        racers[name] += distance;
                    }
                }
            }

            int counter = 1;
            string indicator = string.Empty;

            foreach (var racer in racers.OrderByDescending(x => x.Value).Take(3))
            {
                indicator = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter}{indicator} place: {racer.Key}");
                counter++;
            }
        }
    }
}
