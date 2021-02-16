using System;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            double result = dateModifier.GetDaysDifference(startDate, endDate);

            Console.WriteLine(result);
        }
    }
}
