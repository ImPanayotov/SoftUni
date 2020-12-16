using System;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();

                StringBuilder encryptedPassword = new StringBuilder();

                Regex regex = new
                    Regex(@"^(.+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]{3})<(\1)$");

                if (regex.IsMatch(password))
                {
                    Match match = regex.Match(password);

                    encryptedPassword.Append(match.Groups["first"].Value);
                    encryptedPassword.Append(match.Groups["second"].Value);
                    encryptedPassword.Append(match.Groups["third"].Value);
                    encryptedPassword.Append(match.Groups["fourth"].Value);

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
            }
        }
    }
}
