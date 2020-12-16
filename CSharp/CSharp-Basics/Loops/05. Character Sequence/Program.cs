using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();

            //// length = 7
            //// text[4]
            //Console.WriteLine(text[text.Length - 1]);
            string input = Console.ReadLine();

            int length = input.Length;

            for (int i = 0; i <= length - 1; i ++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
