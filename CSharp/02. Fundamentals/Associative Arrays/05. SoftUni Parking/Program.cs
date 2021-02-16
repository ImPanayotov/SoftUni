using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> lot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    if (lot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {lot.GetValueOrDefault(username) }");
                    }
                    else
                    {
                        lot.Add(username, input[2]);
                        Console.WriteLine($"{username} registered {input[2]} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!lot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        lot.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in lot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
