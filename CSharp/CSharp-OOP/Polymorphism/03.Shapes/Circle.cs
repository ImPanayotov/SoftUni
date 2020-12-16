using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Shapes
{
    public class Circle : Shape
    {
        private double Radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }


        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
