using System;

namespace Shape
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            base.Width = radius;
            base.Height = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * base.Width * base.Height;
        }
    }
}
