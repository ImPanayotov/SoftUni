using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long coolTreshold = 1;
            string coolPattern = @"\d";
            string emojiPattern = @"\*\*[A-Z][a-z]{2,}\*\*|::[A-Z][a-z]{2,}::";

            var results = Regex.Matches(input, coolPattern)
                .Cast<Match>()
                .Select(m => int.Parse(m.Value))
                .ToList();

            for (int i = 0; i < results.Count; i++)
            {
                coolTreshold *= results[i];
            }

            List<string> emojiList = Regex.Matches(input, emojiPattern)
                .Cast<Match>()
                .Select(f => f.Value)
                .ToList();

            List<string> emojis = new List<string>();

            for (int i = 0; i < emojiList.Count; i++)
            {
                emojis.Add(emojiList[i]);
            }

            List<string> coolEmojis = new List<string>();

            for (int i = 0; i < emojis.Count; i++)
            {
                char[] emoji = emojis[i].ToCharArray();

                int sum = 0;

                for (int j = 2; j < emoji.Length - 2; j++)
                {
                    sum += emoji[j];
                }

                if (sum >= coolTreshold)
                {
                    coolEmojis.Add(emojis[i]);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
