using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractC(A, B, C));
        }

        public static int SumAB(int A, int B)
        {
            int result = A + B;
            return result;
        }

        public static int SubtractC(int A, int B, int C)
        {
            int result = SumAB(A, B) - C;
            return result;
        }
    }
}
