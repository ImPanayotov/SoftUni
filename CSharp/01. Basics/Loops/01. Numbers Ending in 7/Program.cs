using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // ot 1 do 1000 zavyrshvashti na 7;
            // povtaryame:
            // proverka dali zavyrshva na 7
            // print

            //for (int number = 1; number <= 1000; number++)
            //{
            //    if (number % 10 == 7)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}
            for (int i = 7; i <= 997; i+=10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
