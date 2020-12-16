using System;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new
                Regex(@"^!(?<name>[A-Z][a-z]{2,})!:\[(?<msg>[A-Za-z]{8,})\]$");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                Console.Write($"{match.Groups["name"].Value}: ");

                char[] ch = match.Groups["msg"].ToString().ToCharArray();
                for (int j = 0; j < ch.Length; j++)
                {
                    Console.Write($"{(int)ch[j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
