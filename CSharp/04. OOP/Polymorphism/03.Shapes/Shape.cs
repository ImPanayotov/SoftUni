using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Shapes
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Radius { get; set; }


        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }


    }
}
