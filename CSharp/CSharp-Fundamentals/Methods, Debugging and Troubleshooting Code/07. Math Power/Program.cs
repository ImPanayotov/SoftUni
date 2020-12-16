using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num, pow));
        }

        static double RaiseToPower(double num, double pow)
        {
            double pnum = 1.0;
            if (pow > 0)
            {
                for (double i = pow; i > 0; i--)
                {
                    pnum = pnum * num;
                }
            }
            else if (pow < 0)
            {
                for (double i = pow; i < 0; i++)
                {
                    pnum = pnum / 2;
                }
            }
            else 
            {
                pnum = 1.0;
            }
            return pnum;
        }
    }
}
