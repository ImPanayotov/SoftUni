using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "Stop")
                {
                    break;
                }

                if (command == "Delete")
                {
                    int index = int.Parse(input[1]) + 1;

                    if (index >= 0 && index < collection.Count)
                    {
                        collection.RemoveAt(index);
                    }
                }
                else if (command == "Swap")
                {
                    string word1 = input[1];
                    string word2 = input[2];

                    if (collection.Contains(word1) && collection.Contains(word2))
                    {
                        int index1 = collection.IndexOf(word1);
                        int index2 = collection.IndexOf(word2);
                        string temp = collection[index1];
                        collection[index1] = collection[index2];
                        collection[index2] = temp;
                    }
                }
                else if (command == "Put")
                {
                    string word = input[1];
                    int index = int.Parse(input[2]) - 1;

                    if (index >= 0 && index <= collection.Count)
                    {
                        collection.Insert(index, word);
                    }

                }
                else if (command == "Sort")
                {
                    collection = collection.OrderByDescending(x => x).ToList();
                }
                else if (command == "Replace")
                {
                    string word1 = input[1];
                    string word2 = input[2];
                    if (collection.Contains(word2))
                    {
                        int index = collection.IndexOf(word2);
                        collection[index] = word1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
