using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollar = pound * 1.31M;

            Console.WriteLine($"{dollar:f3}");
        }
    }
}
