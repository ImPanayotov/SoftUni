using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string chars = string.Empty;
            string digits = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 65 && input[i] <= 90 )
                    || (input[i] >= 97 && input[i] <= 122))
                {
                    chars += input[i];
                }
                else if ((input[i] >= 48 && input[i] <= 57))
                {
                    digits += input[i];
                }
                else
                {
                    symbols += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(symbols);
        }
    }
}
