using System;

namespace Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double sheetArea = double.Parse(Console.ReadLine());

            double totalSheetArea = ((sheets - sheets / 3) * sheetArea) + (sheets / 3 * 0.25 * sheetArea);
            double boxArea = size * size * 6;

            double percent = totalSheetArea / boxArea * 100;
            Console.WriteLine($"You can cover {percent:f2}% of the box.");

        }
    }
}
