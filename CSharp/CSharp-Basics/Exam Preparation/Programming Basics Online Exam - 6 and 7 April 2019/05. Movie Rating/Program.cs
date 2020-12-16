using System;

namespace _05._Movie_Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxRating = 0;
            double minRating = 11;
            string bestTitle = "";
            string worstTitle = "";
            double average = 0;
            for (int i = 1; i <= n; i++)
            {
                string title = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                average += rating;
                if (rating > maxRating)
                {
                    maxRating = rating;
                    bestTitle = title;
                }
                if (rating < minRating)
                {
                    minRating = rating;
                    worstTitle = title;
                }
            }
            Console.WriteLine($"{bestTitle} is with highest rating: {maxRating}");
            Console.WriteLine($"{worstTitle} is with lowest rating: {minRating}");
            Console.WriteLine($"Average rating: {average / n:f1}");
        }
    }
}
