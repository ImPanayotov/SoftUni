using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int d1 = a; d1 <= b; d1++)
                {
                    for (int d2 = a; d2 <= b; d2++)
                    {
                        for (int d3 = a; d3 <= b; d3++)
                        {
                            for (int d4 = a; d4 <= b; d4++)
                            {
                                for (int d5 = a; d5 <= b; d5++)
                                {
                                    bool isValid = a <= d1 &&
                                        d1 < d2 &&
                                        d2 < d3 &&
                                        d3 < d4 &&
                                        d4 < d5 &&
                                        d5 <= b;
                                    if (isValid)
                                    {
                                        Console.WriteLine($"{d1} {d2} {d3} {d4} {d5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
