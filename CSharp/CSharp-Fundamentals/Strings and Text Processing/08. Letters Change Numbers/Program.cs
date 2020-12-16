using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0.0;

            for (int i = 0; i < words.Length; i++)
            {
                sum = ProcessWord(words, sum, i);
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static double ProcessWord(string[] words, double sum, int i)
        {
            double tempSum = 0;

            string currentWord = words[i];

            char firstLetter = currentWord[0];
            char lastLetter = currentWord[currentWord.Length - 1];
            double number = ParseNumberFromInput(currentWord);

            int firstLetterPosition = GetAlphabeticalPositionByLetter(firstLetter);
            int lastLetterPosition = GetAlphabeticalPositionByLetter(lastLetter);

            if (char.IsUpper(firstLetter) && firstLetterPosition > 0)
            {
                tempSum = number / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter) && firstLetterPosition > 0)
            {
                tempSum = number * firstLetterPosition;
            }

            if (char.IsUpper(lastLetter) && lastLetterPosition > 0)
            {
                tempSum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter) && lastLetterPosition > 0)
            {
                tempSum += lastLetterPosition;
            }

            sum += tempSum;
            return sum;
        }

        private static int GetAlphabeticalPositionByLetter(char letter)
        {
            int position = -1;

            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    position = letter - 64;
                }
                else
                {
                    position = letter - 96;
                }
            }

            return position;
        }

        private static double ParseNumberFromInput(string currentWord)
        {
            char[] numberAsCharArray = currentWord
                                .Skip(1)
                                .Take(currentWord.Length - 2)
                                .ToArray();
            string numberAsString = string.Join("", numberAsCharArray);
            double number = double.Parse(numberAsString);

            return number;
        }
    }
}
