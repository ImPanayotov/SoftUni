using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = MathOperations(firstNumber, secondNumber, action);

            Console.WriteLine($"{result:f0}");
        }
        private static double MathOperations(double firstNumber, double secondNumber, char action)
        {
            double result = 0;
            switch (action)
            {
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}
