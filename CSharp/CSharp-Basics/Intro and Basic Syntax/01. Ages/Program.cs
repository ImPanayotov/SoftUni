using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a >= 0 && a <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (a >= 3 && a <= 13)
            {
                Console.WriteLine("child");
            }
            else if (a >= 14 && a <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (a >= 20 && a <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (a >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
