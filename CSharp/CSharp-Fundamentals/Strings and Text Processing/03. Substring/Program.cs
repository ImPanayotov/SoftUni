using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //    On the first line you will receive a string.
            //    On the second line you will receive a second string.
            //    Write a program that removes all of the 
            //    occurrences of the first string in the second 
            //    until there is no match. 
            //    At the end print the remaining string.

            string wordToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (text.Contains(wordToRemove))
            {
                int start = text.IndexOf(wordToRemove);
                text = text.Remove(start, wordToRemove.Length);
            }
            
            Console.WriteLine(text);
        }
    }
}
