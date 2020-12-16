using System;
using System.Linq;

namespace Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Switch")
                {
                    int index = int.Parse(input[1]);
                    SwitchSign(numbers, index);
                }
                else if (command == "Change")
                {
                    int index = int.Parse(input[1]);
                    int value = int.Parse(input[2]);

                    ChangeNumber(numbers, index, value);
                }
                else if (command == "Sum")
                {
                    string sign = input[1];

                    if (sign == "Negative")
                    {
                        PrintSumOfNegativeNumbers(numbers);
                    }
                    else if (sign == "Positive")
                    {
                        PrintSumOfPositiveNumbers(numbers);
                    }
                    else if (sign == "All")
                    {
                        PrintSumOfNumbers(numbers);
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        public static int[] SwitchSign(int[] numbers, int index)
        {
            if (index >= 0 && index < numbers.Length)
            {
                if (numbers[index] != 0)
                {
                    numbers[index] *= -1;
                }
            }

            return numbers;
        }

        public static int[] ChangeNumber(int[] numbers, int index, int value)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] = value;
            }

            return numbers;
        }

        public static void PrintSumOfNegativeNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }

        public static void PrintSumOfPositiveNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }

        public static void PrintSumOfNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
