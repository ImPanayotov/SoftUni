using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> followers =
                new Dictionary<string, Dictionary<string, List<int>>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();

                string cmd = input[0];

                if (cmd == "Log out")
                {
                    break;
                }

                if (cmd == "New follower")
                {
                    string username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        AddFollower(followers, username);
                    }
                }
                else if (cmd == "Like")
                {
                    string username = input[1];
                    int count = int.Parse(input[2]);

                    if (!followers.ContainsKey(username))
                    {
                        AddFollower(followers, username, count);
                    }
                    else
                    {
                        followers[username]["Likes"][0] += count;
                    }

                }
                else if (cmd == "Comment")
                {
                    string username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        AddFollower(followers, username);
                    }

                    followers[username]["Comments"][0] += 1;
                }
                else if (cmd == "Blocked")
                {
                    string username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        followers.Remove(username);
                    }
                }
            }

            Console.WriteLine($"{followers.Count} followers");

            foreach (var follower in followers
                .OrderByDescending(x => x.Value["Likes"][0])
                .ThenBy(x => x.Key))
            {
                int sum = follower.Value["Likes"][0] + follower.Value["Comments"][0];
                
                Console.WriteLine($"{follower.Key}: {sum}");
            }
        }

        private static void AddFollower(Dictionary<string, Dictionary<string, List<int>>> followers, string username)
        {
            followers.Add(username, new Dictionary<string, List<int>>());

            followers[username].Add("Likes", new List<int>());
            followers[username].Add("Comments", new List<int>());

            followers[username]["Likes"].Add(0);
            followers[username]["Comments"].Add(0);
        }

        private static void AddFollower(Dictionary<string, Dictionary<string, List<int>>> followers, string username, int count)
        {
            followers.Add(username, new Dictionary<string, List<int>>());

            followers[username].Add("Likes", new List<int>());
            followers[username].Add("Comments", new List<int>());

            followers[username]["Likes"].Add(count);
            followers[username]["Comments"].Add(0);
        }
    }
}
