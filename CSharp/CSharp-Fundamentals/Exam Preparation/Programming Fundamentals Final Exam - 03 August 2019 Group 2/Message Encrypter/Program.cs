using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new
                Regex(@"(\*|\@)([A-Z][a-z]{2,})(\*|\@):\s\[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$");

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

                string one = match.Groups[4].Value;
                string two = match.Groups[5].Value;
                string three = match.Groups[6].Value;

                char[] oneArr = one.ToCharArray();
                char[] twoArr = two.ToCharArray();
                char[] threeArr = three.ToCharArray();

                if (oneArr.Length == 1 && twoArr.Length == 1 && threeArr.Length == 1)
                {
                    int firstCh = oneArr[0];
                    int secondCh = twoArr[0];
                    int thirdCh = threeArr[0];
                    Console.WriteLine($"{tag}: {firstCh} {secondCh} {thirdCh}");
                }
            }
        }
    }
}
