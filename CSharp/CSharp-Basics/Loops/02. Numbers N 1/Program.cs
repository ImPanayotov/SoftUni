using System;

namespace _02._Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int num = input; num > 0; num --)
            {
                Console.WriteLine(num);
            }
        }
    }
}
