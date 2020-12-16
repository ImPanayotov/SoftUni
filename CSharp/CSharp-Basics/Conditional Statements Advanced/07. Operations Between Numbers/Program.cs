using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            // + - * / %

            switch (operation)
            {
                case '+':
                    int sum = number1 + number2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {sum} - odd");
                    }
                    break;

                case '-':
                    int result = number1 - number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result} - odd");
                    }
                    break;

                case '*':
                    int multiplication = number1 * number2;
                    if (multiplication % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {multiplication} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {multiplication} - odd");
                    }
                    break;

                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double division = number1 * 1.0 / number2;
                        Console.WriteLine($"{number1} {operation} {number2} = {division:f2}");
                    }
                    break;

                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        int left = number1 % number2;
                        Console.WriteLine($"{number1} {operation} {number2} = {left}");
                    }
                    break;
            }
        }
    }
}
