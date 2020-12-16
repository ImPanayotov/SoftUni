using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (occurrences.ContainsKey(text[i]))
                {
                    occurrences[text[i]] += 1;
                }
                else
                {
                    occurrences.Add(text[i], 1);
                }
            }

            foreach (var symbol in occurrences.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");

            }
        }
    }
}
