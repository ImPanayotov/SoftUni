using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string[] substrings = Console.ReadLine().Split().ToArray();

            char[] ch = encrypted.ToCharArray();

            char[] validChars = "defghijklmnopqrstuvwxyz{}|#".ToCharArray();

            for (int i = 0; i < encrypted.Length; i++)
            {
                if (!validChars.Contains(encrypted[i]))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }

            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = (char)(ch[i] - 3);
            }

            encrypted = new string(ch);

            string substring1 = substrings[0];
            string substring2 = substrings[1];

            encrypted = encrypted.Replace(substring1, substring2);

            Console.WriteLine(encrypted);
        }
    }
}
