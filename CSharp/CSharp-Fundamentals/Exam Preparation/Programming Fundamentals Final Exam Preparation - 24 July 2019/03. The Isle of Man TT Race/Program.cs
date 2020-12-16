using System;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new
                Regex(@"^(?<firstSign>[#|$|%|*|&]{1})(?<name>[A-Za-z]{1,})(?<secondSign>[#|$|%|*|&]{1})=(?<length>[0-9]{1,})!!(?<ghc>.{1,})$");

            while (true)
            {
                string input = Console.ReadLine();

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                Match match = regex.Match(input);

                string name = match.Groups["name"].Value;
                int length = int.Parse(match.Groups["length"].Value);
                string geoHashCode = match.Groups["ghc"].Value;
                string firstSign = match.Groups["firstSign"].Value;
                string secondSign = match.Groups["secondSign"].Value;

                if (length != geoHashCode.Length || firstSign != secondSign)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                char[] ch = geoHashCode.ToCharArray();

                for (int i = 0; i < ch.Length; i++)
                {
                    ch[i] = (char)(ch[i]+ length);
                }

                geoHashCode = string.Join("", ch);

                Console.WriteLine($"Coordinates found! {name} -> {geoHashCode}");

                break;
            }
        }
    }
}
