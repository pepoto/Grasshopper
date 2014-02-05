
namespace Shape
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public abstract double CalculateSurface();
    }
}
