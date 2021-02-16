using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("vowel");

            }
            else if (input == '0' || input == '1' || input == '2' || input == '3' || input == '4' || input == '5' || input == '6' || input == '7' || input == '8' || input == '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
