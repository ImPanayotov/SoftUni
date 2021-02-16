using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upperChecker = s => s[0] == s.ToUpper()[0];
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(upperChecker)
                .ToArray();

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
