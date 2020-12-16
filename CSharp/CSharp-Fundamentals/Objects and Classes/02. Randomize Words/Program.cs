using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int j = rnd.Next(0, words.Length);

                if (i != j)
                {
                    string old = words[i];
                    words[i] = words[j];
                    words[j] = old;

                }
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
