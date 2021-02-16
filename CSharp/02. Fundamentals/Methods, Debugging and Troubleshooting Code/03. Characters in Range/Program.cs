using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharsBetweenTwoChars(start, end);
        }

        public static void PrintCharsBetweenTwoChars(char start, char end)
        {
            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
