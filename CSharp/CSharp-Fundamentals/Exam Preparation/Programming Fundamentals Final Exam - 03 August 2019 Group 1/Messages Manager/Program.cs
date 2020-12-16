using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> stats =
                new Dictionary<string, Dictionary<string, List<int>>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("=").ToArray();

                string command = input[0];

                if (command == "Statistics")
                {
                    break;
                }

                if (command == "Add")
                {
                    string username = input[1];
                    int sent = int.Parse(input[2]);
                    int received = int.Parse(input[3]);

                    if (!stats.ContainsKey(username))
                    {
                        stats.Add(username, new Dictionary<string, List<int>>());
                    }

                    //adding sent msg's to user
                    if (!stats[username].ContainsKey("Sent"))
                    {
                        stats[username].Add("Sent", new List<int>());
                        stats[username]["Sent"].Add(sent);
                    }

                    //adding received msg's to user
                    if (!stats[username].ContainsKey("Received"))
                    {
                        stats[username].Add("Received", new List<int>());
                        stats[username]["Received"].Add(received);
                    }
                }
                else if (command == "Message")
                {
                    string sender = input[1];
                    string receiver = input[2];

                    if (stats.ContainsKey(sender) && stats.ContainsKey(receiver))
                    {
                        if (sender != receiver)
                        {
                            stats[receiver]["Received"][0] += 1;
                        }

                        stats[sender]["Sent"][0] += 1;

                        if (stats[sender]["Sent"][0] + stats[sender]["Received"][0] >= capacity)
                        {
                            stats.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }

                        if (stats[receiver]["Sent"][0] + stats[receiver]["Received"][0] >= capacity)
                        {
                            stats.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }

                    }
                }
                else if (command == "Empty")
                {
                    string username = input[1];
                    if (username == "All")
                    {
                        stats.Clear();
                    }

                    if (stats.ContainsKey(username))
                    {
                        stats.Remove(username);
                    }
                }
            }

            Console.WriteLine($"Users count: {stats.Count}");

            if (stats.Count > 0)
            {
                foreach (var user in stats
                    .OrderByDescending(x => x.Value["Received"][0])
                    .ThenBy(x => x.Key))
                {
                    int sum = user.Value["Sent"].Sum() + user.Value["Received"].Sum();

                    Console.WriteLine($"{user.Key} - {sum}");
                }
            }
        }
    }
}
