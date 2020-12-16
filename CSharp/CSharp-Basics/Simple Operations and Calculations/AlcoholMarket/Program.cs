using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());

            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.4);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            double rakiaSum = rakiaPrice * rakiaQuantity;
            double wineSum = winePrice * wineQuantity;
            double beerSum = beerPrice * beerQuantity;
            double whiskeySum = whiskeyPrice * whiskeyQuantity;

            double total = rakiaSum + wineSum + beerSum + whiskeySum;

            Console.WriteLine($"{total:f2}");
        }
    }
}
