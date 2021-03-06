﻿using System;
using System.Runtime.ExceptionServices;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            switch (action)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
