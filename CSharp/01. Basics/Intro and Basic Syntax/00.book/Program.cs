using System;

namespace _00.book
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10101;
            Console.WriteLine("|{0, 25:c}|", a); 
            Console.WriteLine("|{0, -25:c}|", a); 
        }
    }
}
