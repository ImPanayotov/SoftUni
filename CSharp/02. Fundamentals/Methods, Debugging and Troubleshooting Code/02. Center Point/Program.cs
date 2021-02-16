using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestToZero(x1, y1, x2, y2);

            
        }
        public static void ClosestToZero(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first < secound)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
