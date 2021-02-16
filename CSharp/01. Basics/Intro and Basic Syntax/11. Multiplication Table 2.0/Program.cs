using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());

            if (multi > 10)
            {
                for (int i = multi; i == multi; i++)
                {
                    Console.WriteLine($"{n} X {multi} = {n * multi}");
                    break;
                }
            }
            for (int i = 1; multi <= 10; i++)
            {
                Console.WriteLine($"{n} X {multi} = {n * multi}");
                multi++;
            }
        }
    }
}
