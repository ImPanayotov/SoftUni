using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new
                Regex(@"^\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Z]*[a-z]*\s[A-Z]*[a-z]*)#$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string name = match.Groups["boss"].Value;
                    string title = match.Groups["title"].Value;
                    int strength = match.Groups["boss"].Value.Length;
                    int armour = match.Groups["title"].Value.Length;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armour: {armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
