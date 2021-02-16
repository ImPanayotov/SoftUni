using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex =
                new Regex(@"^(?<nameofpeak>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<code>(.*?)+)$");

            while (true)
            {
                string msg = Console.ReadLine();

                if (msg == "Last note")
                {
                    break;
                }

                if (!regex.IsMatch(msg))
                {
                    Console.WriteLine("Nothing found!");
                }
                else
                {
                    Match match = regex.Match(msg);

                    int length = int.Parse(match.Groups["length"].Value);
                    string code = new string(match.Groups["code"].Value);

                    if (length != code.Length)
                    {
                        Console.WriteLine($"Nothing found!");
                        continue;
                    }

                    string nameOfPeak = string.Empty;
                    char[] ch = match.Groups["nameofpeak"].Value.ToCharArray();

                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (char.IsLetterOrDigit(ch[i]))
                        {
                            nameOfPeak += ch[i];
                        }
                    }

                    Console.WriteLine($"Coordinates found! {nameOfPeak} -> {code}");
                }
            }
        }
    }
}
