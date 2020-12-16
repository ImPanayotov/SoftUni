using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usernames =
                new Dictionary<string, int>();

            Dictionary<string, int> languages =
                new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();

                if (input[0] == "exam finished")
                {
                    break;
                }

                string username = input[0];

                if (input[1] == "banned")
                {
                    if (usernames.ContainsKey(username))
                    {
                        usernames.Remove(username);

                        continue;

                    }
                }

                string language = input[1];
                int points = int.Parse(input[2]);

                if (usernames.ContainsKey(username))
                {
                    if (usernames[username] < points)
                    {
                        usernames[username] = points;
                    }
                }
                else
                {
                    usernames.Add(username, points);
                }

                if (languages.ContainsKey(language))
                {
                    languages[language]++;
                }
                else
                {
                    languages.Add(language, 1);
                }
            }

            Console.WriteLine("Results:");

            foreach (var kvp in usernames.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
