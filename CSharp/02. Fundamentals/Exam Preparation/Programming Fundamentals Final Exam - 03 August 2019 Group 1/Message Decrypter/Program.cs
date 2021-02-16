using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new
                Regex(@"^(\%|\$)([A-Z]{1}[a-z]{2,})(\$|\%): \[(\d+)]\|\[(\d+)]\|\[(\d+)]\|$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);


                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string tag = match.Groups[2].Value;
                string specialCh1 = match.Groups[1].Value;
                string specialCh2 = match.Groups[3].Value;

                if (specialCh1 != specialCh2)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                int firstChAsInt = int.Parse(match.Groups[4].Value);
                int secondCharAsInt = int.Parse(match.Groups[5].Value);
                int thirdCharAsInt = int.Parse(match.Groups[6].Value);

                char firstCh = (char)firstChAsInt;
                char secondCh = (char)secondCharAsInt;
                char thirdCh = (char)thirdCharAsInt;

                Console.WriteLine($"{tag}: {firstCh}{secondCh}{thirdCh}");
            }
        }
    }
}
