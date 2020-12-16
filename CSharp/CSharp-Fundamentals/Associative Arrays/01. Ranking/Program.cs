using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword =
                new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> ranking =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(":")
                    .ToArray();

                string contest = input[0];

                if (contest == "end of contests")
                {
                    break;
                }

                string password = input[1];

                contestAndPassword.Add(contest, password);
            }

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split("=>")
                    .ToArray();

                string contest = input[0];

                if (contest == "end of submissions")
                {
                    break;
                }

                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contestAndPassword.ContainsKey(contest)
                    && contestAndPassword.ContainsValue(password))
                {
                    if (!ranking.ContainsKey(username))
                    {
                        ranking.Add(username, new Dictionary<string, int>());
                        ranking[username].Add(contest, points);
                    }

                    if (!ranking[username].ContainsKey(contest))
                    {
                        ranking[username].Add(contest, points);
                    }
                    else
                    {
                        if (points > ranking[username][contest])
                        {
                            ranking[username][contest] = points;
                        }
                    }
                }
            }

            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var kvp in ranking)
            {
                totalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestCandidate = totalPoints.Keys.Max();
            int bestPoints = totalPoints.Values.Max();

            foreach (var kvp in totalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking: ");

            foreach (var name in ranking.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);

                foreach (var contest in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
