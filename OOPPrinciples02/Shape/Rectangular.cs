
namespace Shape
{
    public class Rectangular : Shape
    {
        public Rectangular(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}
