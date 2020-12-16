using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            while (true)
            {
                string inputInfo = Console.ReadLine();


                if (inputInfo == "Sign up")
                {
                    break;
                }

                string[] input = inputInfo.Split().ToArray();

                string cmd = input[0];

                if (cmd == "Case")
                {
                    string upperOrLower = input[1];

                    if (upperOrLower == "upper")
                    {
                        username = username.ToUpper();
                    }
                    else
                    {
                        username = username.ToLower();
                    }

                    Console.WriteLine(username);
                }
                else if (cmd == "Reverse")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);

                    if (start >= 0 && end > start && end < username.Length)
                    {
                        string substring = username.Substring(start, (end - start) + 1);

                        Console.WriteLine(string.Join("", substring.Reverse()));
                    }
                }
                else if (cmd == "Cut")
                {
                    string substring = input[1];

                    if (username.Contains(substring))
                    {
                        int start = username.IndexOf(substring);
                        int length = substring.Length;

                        username = username.Remove(start, length);

                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }
                else if (cmd == "Replace")
                {
                    string substring = input[1];

                    username = username.Replace(substring, "*");

                    Console.WriteLine(username);
                }
                else if (cmd == "Check")
                {
                    string word = input[1];

                    if (username.Contains(word))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {word}.");
                    }
                }
            }
        }
    }
}
