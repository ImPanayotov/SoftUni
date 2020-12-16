using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<char> textAsChars = text.ToList();
            List<int> sumOfNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int numLength = numbers[i].ToString().Length;
                for (int j = 0; j < numLength; j++)
                {
                    int digit = numbers[i] % 10;
                    sum += digit;
                    numbers[i] /= 10;
                }
                sumOfNumbers.Add(sum);
            }

            List<char> output = new List<char>();
            for (int i = 0; i < sumOfNumbers.Count; i++)
            {
                int index = sumOfNumbers[i];
                if (sumOfNumbers[i] >= textAsChars.Count)
                {
                    index = sumOfNumbers[i] - textAsChars.Count;
                }
                output.Add(textAsChars[index]);
                textAsChars.RemoveAt(index);
            }

            foreach (var item in output)
            {
                Console.Write(item);
            }
        }
    }
}
