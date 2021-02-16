using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                int subsequence = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    char nextchar = input[j];

                    if (currentChar == nextchar)
                    {
                        subsequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                input = input.Remove(i + 1, subsequence);
            }

            Console.WriteLine(input);
        }
    }
}
