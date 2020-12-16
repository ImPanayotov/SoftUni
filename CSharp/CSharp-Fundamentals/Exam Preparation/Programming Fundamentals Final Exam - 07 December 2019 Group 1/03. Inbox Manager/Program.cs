using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> usernames =
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->").ToArray();

                string command = input[0];

                if (command == "Statistics")
                {
                    break;
                }

                if (command == "Add")
                {
                    string username = input[1];

                    if (!usernames.ContainsKey(username))
                    {
                        usernames.Add(username, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }
                else if (command == "Send")
                {
                    string username = input[1];
                    string email = input[2];

                    if (usernames.ContainsKey(username))
                    {
                        usernames[username].Add(email);
                    }
                }
                else if (command == "Delete")
                {
                    string username = input[1];

                    if (usernames.ContainsKey(username))
                    {
                        usernames.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }

            Console.WriteLine($"Users count: {usernames.Count}");

            if (usernames.Count > 0)
            {
                foreach (var user in usernames
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine(user.Key);

                    foreach (var email in user.Value)
                    {
                        Console.WriteLine($"- {email}");
                    }
                }
            }
        }
    }
}
