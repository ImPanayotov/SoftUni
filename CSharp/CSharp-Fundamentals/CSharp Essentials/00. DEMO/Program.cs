using System;

namespace _00._DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITE ALL NUMS FROM AN ARRAY
            //int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //foreach (int i in n)
            //{
            //    Console.WriteLine("Numbers: {0}, ", i);
            //}
            string[] numbersAsString = Console.ReadLine().Split();
            int[] numbers = new int[numbersAsString.Length];
            

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsString[i]);
            }

            int rotation = int.Parse(Console.ReadLine());
            int realRotation = rotation % numbers.Length; 

            for (int i = 0; i < realRotation; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
