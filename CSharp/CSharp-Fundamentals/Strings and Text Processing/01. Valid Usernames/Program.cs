using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.None)
                .ToArray();

            foreach (var username in input)
            {
                if (ValidateUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool ValidateUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char currCh = username[i];

                if (!(char.IsLetterOrDigit(currCh) || currCh == '-' || currCh == '_'))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}


