using System;
using System.Text.RegularExpressions;

namespace _01._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new
                Regex(@"^([#$%*&]{1})(?<name>[A-Za-z]+)\1=(?<length>[0-9]+)!!(?<code>.+)$");


            while (true)
            {
                string input = Console.ReadLine();

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                Match match = regex.Match(input);

                string code = match.Groups["code"].Value;
                int length = int.Parse(match.Groups["length"].Value);

                if (code.Length != length)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                char[] ch = code.ToCharArray();

                for (int i = 0; i < ch.Length; i++)
                {
                    ch[i] = (char)(ch[i] + length);
                }

                code = new string(ch);

                string name = match.Groups["name"].Value;

                Console.WriteLine($"Coordinates found! {name} -> {code}");

                return;
            }
        }
    }
}
