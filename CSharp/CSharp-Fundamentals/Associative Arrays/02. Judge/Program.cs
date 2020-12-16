using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judge =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "no more time")
                {
                    break;
                }

                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!judge.ContainsKey(contest))
                {
                    judge.Add(contest, new Dictionary<string, int>());
                }
                if (!judge[contest].ContainsKey(username))
                {
                    judge[contest].Add(username, points);
                }
                else
                {
                    if (points > judge[contest][username])
                    {
                        judge[contest][username] = points;
                    }
                }
            }

            foreach (var contest in judge)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
               
                int participantsPosition = 0;
                
                foreach (var kvp in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    participantsPosition++;
                    Console.WriteLine($"{participantsPosition}. {kvp.Key} <::> {kvp.Value}");
                }
            }

            Dictionary<string, int> standings = new Dictionary<string, int>();

            foreach (var contest in judge)
            {
                foreach (var name in contest.Value)
                {
                    if (!standings.ContainsKey(name.Key))
                    {
                        standings.Add(name.Key, name.Value);
                    }
                    else
                    {
                        standings[name.Key] += name.Value;
                    }
                }
            }

            Console.WriteLine("Individual standings:");

            int standingsPosition = 0;

            foreach (var name in standings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                standingsPosition++;
                Console.WriteLine($"{standingsPosition}. {name.Key} -> {name.Value}");
            }
        }
    }
}
