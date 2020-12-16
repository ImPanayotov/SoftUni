using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    int numbet = int.Parse(input);
                        counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
