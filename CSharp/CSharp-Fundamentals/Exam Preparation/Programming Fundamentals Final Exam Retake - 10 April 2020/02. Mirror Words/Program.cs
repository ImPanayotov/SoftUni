using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mirorWords = new List<string>();

            string text = Console.ReadLine();

            Regex regex = new
                Regex(@"(@|#)(?<FirstWord>[A-Za-z]{3,})\1\1(?<SecondWord>[A-Za-z]{3,})\1");

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["FirstWord"].Value;
                    string secondWord = match.Groups["SecondWord"].Value;

                    char[] secondToChar = secondWord.ToCharArray();
                    Array.Reverse(secondToChar);
                    string secondReversed = new string(secondToChar);

                    if (firstWord == secondReversed)
                    {
                        string miror = firstWord + " <=> " + secondWord;
                        mirorWords.Add(miror);
                    }
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (mirorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirorWords));
            }
        }
    }
}
