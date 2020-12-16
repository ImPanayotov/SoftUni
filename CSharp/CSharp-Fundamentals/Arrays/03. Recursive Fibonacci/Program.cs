using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static int GetFibonacci(int n)
        {
            return (n < 2) ? n : GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
        public static void Main()
        {
            Console.Write(GetFibonacci(int.Parse(Console.ReadLine())));
        }
    }
}
