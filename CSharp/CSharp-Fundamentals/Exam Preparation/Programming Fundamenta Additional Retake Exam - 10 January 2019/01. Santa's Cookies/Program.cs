using System;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 0; i < batches; i++)
            {
                double flour = double.Parse(Console.ReadLine());
                double sugar = double.Parse(Console.ReadLine());
                double cocoa = double.Parse(Console.ReadLine());

                double flourCups = flour / 140;
                flour -= flour / 140;
                double sugarSpoon = sugar / 20;
                sugar -= sugar / 20;
                double cocoaSpoon = cocoa / 10;
                cocoa -= cocoa / 10;

                double totalCookiesPerBake = (140 * +10 + 20) * (Math.Min(Math.Min(flourCups, sugarSpoon), cocoaSpoon)) / 25;
                if (cocoaSpoon <=0 || sugarSpoon <=0 || flourCups <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                Console.WriteLine($"Boxes of cookies: {Math.Floor(totalCookiesPerBake / 5)}");
            }
        }
    }
}
