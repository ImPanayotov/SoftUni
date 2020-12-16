using System;

namespace _01._Series_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int numSeasons = int.Parse(Console.ReadLine());
            int numEpisodes = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            int allEpisodes = numEpisodes * numSeasons;
            double episodeWithAds = length * 1.20;
            double totalLength = (numSeasons * 10) + allEpisodes * length * 1.20;


            Console.WriteLine($"Total time needed to watch the {title} series is {Math.Floor(totalLength)} minutes.");
        }
    }
}
