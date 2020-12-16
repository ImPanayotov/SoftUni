using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict =
                new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" | ").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] words = input[i].Split(": ").ToArray();
                string word = words[0];
                string definition = words[1];
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }

                dict[word].Add(definition);

            }

            string[] input2 = Console.ReadLine().Split(" | ").ToArray();

            for (int i = 0; i < input2.Length; i++)
            {
                string word = input2[i];

                if (dict.ContainsKey(word))
                {
                    Console.WriteLine($"{word}");

                    foreach (var def in dict[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"-{def}");

                    }
                }
            }

            string input3 = Console.ReadLine();

            if (input3 == "List")
            {
                foreach (var word in dict.OrderBy(x=> x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
            else if (input3 == "End")
            {
                return;
            }
        }
    }
}
