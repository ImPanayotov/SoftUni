using System;

namespace _01._Movie_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaProfit = int.Parse(Console.ReadLine());


            double totalEntryPerDay = tickets * ticketPrice;
            double totalEntry = totalEntryPerDay * days;
            double profit = totalEntry * cinemaProfit / 100;
            
            double total = totalEntry - profit;


            Console.WriteLine($"The profit from the movie {title} is {total:f2} lv.");

        }
    }
}
