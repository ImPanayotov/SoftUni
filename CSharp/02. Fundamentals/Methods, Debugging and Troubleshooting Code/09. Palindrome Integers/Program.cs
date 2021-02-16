using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                Palindrome(input);
                
            }

        }
        public static void Palindrome(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new String(charArray);
            bool result = input.Equals(reversedInput);
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
