using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        public static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                int index = input.Length / 2;
                char middleChar1 = input[index - 1];
                char middleChar2 = input[index];
                Console.WriteLine($"{middleChar1}{middleChar2}");
            }
            else
            {
                int index = input.Length / 2;
                char middleChar = input[index];
                Console.WriteLine(middleChar);
            }
        }
    }
}
