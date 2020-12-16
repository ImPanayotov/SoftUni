using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(\d{2})(.)(\w{3})\2([0-9]{4})");

            var matches = regex.Matches(input);

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, " +
                    $"Month: {date.Groups[3]}, " +
                    $"Year: {date.Groups[4]}");
            }
        }
    }
}
