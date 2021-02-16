using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char symbol = Convert.ToChar(i);
                Console.Write($"{symbol} ");
            }
        }
    }
}
