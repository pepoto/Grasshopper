using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
