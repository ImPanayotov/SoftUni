using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1 = char.Parse(Console.ReadLine());
            int ch2 = char.Parse(Console.ReadLine());
            int sum = 0;
            char[] inputAsChars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < inputAsChars.Length; i++)
            {
                if (inputAsChars[i] > ch1 && inputAsChars[i] < ch2)
                {
                    sum += inputAsChars[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
