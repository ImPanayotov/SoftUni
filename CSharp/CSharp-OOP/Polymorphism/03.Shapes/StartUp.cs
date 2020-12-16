using _03.Shapes;
using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(15);
            Rectangle rect = new Rectangle(10, 5);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine();
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());
            Console.WriteLine();
            Console.WriteLine(circle.Draw());
            Console.WriteLine(rect.Draw());
        }
    }
}
