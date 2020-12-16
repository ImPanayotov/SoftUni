using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, List<double>>> demons =
                new SortedDictionary<string, Dictionary<string, List<double>>>();

            Regex regexForNums = new Regex(@"[+-]?[\d+\.]*[\d]+");

            Regex regexForSigns = new Regex(@"[*\|/]");

            char[] excludedChars = "0123456789+-*/.".ToCharArray();

            NumberFormatInfo format = new NumberFormatInfo();
            format.NegativeSign = "-";
            format.NumberDecimalSeparator = ".";
            
            string[] input = Console.ReadLine()
                .Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int health = 0;
                double damage = 0;
                string name = input[i];
                char[] charArray = name.ToCharArray();

                for (int j = 0; j < charArray.Length; j++)
                {
                    if (!excludedChars.Contains(charArray[j]))
                    {
                        health += charArray[j];
                    }
                }

                MatchCollection numbers = regexForNums.Matches(input[i]);
                foreach (Match match in numbers)
                {
                    damage += Double.Parse(match.Value, format);
                }

                MatchCollection signs = regexForSigns.Matches(input[i]);
                foreach (Match match in signs)
                {
                    if (match.ToString() == "/")
                    {
                        damage /= 2;
                    }
                    else if (match.ToString() == "*")
                    {
                        damage *= 2;
                    }
                }

                demons.Add(name, new Dictionary<string, List<double>>());
                demons[name].Add("health", new List<double>() { health });
                demons[name].Add("damage", new List<double>() { damage });
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value["health"][0]} health, {demon.Value["damage"][0]:f2} damage");
            }
        }
    }
}
