using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                string censor = new string('*', banWords[i].Length);
                text = text.Replace(banWords[i], censor);
            }

            Console.WriteLine(text) ;
        }
    }
}
