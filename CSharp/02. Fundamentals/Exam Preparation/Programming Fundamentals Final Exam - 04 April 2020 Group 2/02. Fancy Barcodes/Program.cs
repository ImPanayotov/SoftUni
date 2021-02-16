using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new
                Regex(@"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string productGroup = string.Empty;

                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                for (int j = 0; j < match.Groups[1].Value.Length; j++)
                {
                    if (char.IsDigit(match.Groups[1].Value[j]))
                    {
                        productGroup += match.Groups[1].Value[j];
                    }
                }

                if (productGroup == string.Empty)
                {
                    Console.WriteLine($"Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {productGroup}");
                }
            }
        }
    }
}
