using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingBracketCounter = 0;
            int closingBracketCounter = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBracketCounter++;
                }
                if (input == ")")
                {
                    closingBracketCounter++;
                }
                if (closingBracketCounter > openingBracketCounter)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (openingBracketCounter == closingBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
