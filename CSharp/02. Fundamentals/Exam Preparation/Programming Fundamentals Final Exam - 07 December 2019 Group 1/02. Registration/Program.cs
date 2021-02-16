using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int successfulRegistrations = 0;
            Regex regex = new
                Regex(@"^(U\$)(?<name>[A-Z][a-z]{2,})(U\$)(P\@\$)(?<pass>[A-Za-z]{5,}[0-9]+)(P\@\$)$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Invalid username or password");
                    continue;
                }
                else
                {
                    string username = match.Groups["name"].Value;
                    string password = match.Groups["pass"].Value;
                    successfulRegistrations++;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrations}");
        }
    }
}
