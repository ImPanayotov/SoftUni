using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int j = 0; j < word.Length; j++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
