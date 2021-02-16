using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSymbols = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberOfSymbols; i++)
            {
                string number = Console.ReadLine();
                int numberOfDigits = number.Length;
                string firstNumber = Convert.ToChar(number[0]).ToString();
                
            }




        }
    }
}
