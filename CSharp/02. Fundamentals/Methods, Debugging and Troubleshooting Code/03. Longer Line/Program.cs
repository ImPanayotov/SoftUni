using System;

namespace _02._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);


        }
        public static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (DistanceBetweenTwoPoints(x1, y1, x2, y2) >= DistanceBetweenTwoPoints(x3, y3, x4, y4))
            {
                ClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosestPoint(x3, y3, x4, y4);
            }
        }
        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (DistanceBetweenTwoPoints(x1, y1, 0, 0) <= DistanceBetweenTwoPoints(x2, y2, 0, 0))
            {
                Console.Write($"({x1}, {y1})");
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.WriteLine($"({x1}, {y1})");

            }
        }
        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double xDiff = x2 - x1;
            double yDiff = y2 - y1;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }
}
