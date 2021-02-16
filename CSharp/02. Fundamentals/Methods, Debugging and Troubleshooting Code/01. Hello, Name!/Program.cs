using System;

namespace _01._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintName();
        }

        static void PrintName()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"Hello, {input}!");
        }
    }
}
