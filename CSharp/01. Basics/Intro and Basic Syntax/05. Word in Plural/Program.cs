using System;

namespace _05._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith('y'))
            {
                word = word.Remove(word.Length - 1, 1) + "ies";
            }
            else if (word.EndsWith('o') || 
                word.EndsWith("ch") || 
                word.EndsWith('s') ||
                word.EndsWith("sh") ||
                word.EndsWith('x') ||
                word.EndsWith('z'))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
        }
    }
}
