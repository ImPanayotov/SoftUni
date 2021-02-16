using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] inputArgs = input
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input.Contains("|"))
                {
                    string side = inputArgs[0];
                    string user = inputArgs[1];

                    AddUserToSide(book, side, user);
                }
                else if (input.Contains("->"))
                {
                    string user = inputArgs[0];
                    string side = inputArgs[1];
                    MoveUserToSide(book, user, side);
                }
            }

            PrintOutput(book);
        }

        private static void PrintOutput(Dictionary<string, List<string>> book)
        {
            Dictionary<string, List<string>> orderedBook = book
                            .Where(kvp => kvp.Value.Count > 0)
                            .OrderByDescending(kvp => kvp.Value.Count)
                            .ThenBy(kvp => kvp.Key)
                            .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in orderedBook)
            {
                string currentSide = kvp.Key;
                List<string> currentSideUsers = kvp.Value
                    .OrderBy(u => u)
                    .ToList();

                Console.WriteLine($"Side: {currentSide}, " +
                    $"Members: {currentSideUsers.Count}");

                foreach (string user in currentSideUsers)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        private static void MoveUserToSide(Dictionary<string, List<string>> book, string user, string side)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(user))
                {
                    kvp.Value.Remove(user);
                }
            }

            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }

            book[side].Add(user);
            Console.WriteLine($"{user} joins the {side} side!");
        }

        private static void AddUserToSide(Dictionary<string, List<string>> book, string side, string user)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }

            if (!book.Values.Any(l => l.Contains(user)))
            {
                book[side].Add(user);
            }
        }
    }
}
