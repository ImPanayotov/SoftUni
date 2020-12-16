using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double cakeProfit = (cakes * 45);
            double waffleProfit = (waffles * 5.80);
            double pancakeProfit = (pancakes * 3.20);
            double profitPerDayByOne = cakeProfit + waffleProfit + pancakeProfit;
            double profitPerDayByAll = profitPerDayByOne * bakers;
            double totalProfit = profitPerDayByAll * days;
            double expenses = totalProfit / 8;
            double finalProfit = totalProfit - expenses;

            Console.WriteLine($"{finalProfit:f2}");
        }
    }
}
