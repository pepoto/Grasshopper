using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class TestShape
    {

        public static void MyFavouriteConsoleStyle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void PrintMyLine()
        {
            Console.WriteLine(new string('*', 60));
        }

        static void Main(string[] args)
        {
            //01.Define abstract class Shape with only one abstract method CalculateSurface()
            //and fields width and height. Define two new classes Triangle and Rectangle
            //that implement the virtual method and return the surface of the figure 
            //(height*width for rectangle and height*width/2 for triangle).
            //Define class Circle and suitable constructor so that at initialization height
            //must be kept equal to width and implement the CalculateSurface() method. 
            //Write a program that tests the behavior of  the CalculateSurface() method for
            //different shapes (Circle, Rectangle, Triangle) stored in an array.

            MyFavouriteConsoleStyle();
            PrintMyLine();
            Shape triangle = new Triangle(10, 12);
            Shape rectangular = new Rectangular(10, 20);
            Shape circle = new Circle(15);
            Circle circle2 = new Circle(10);
            Shape[] shapes ={
                                triangle,
                                rectangular,
                                circle,
                                circle2
                            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine(shape.CalculateSurface());
            }
            PrintMyLine();


        }
    }
}
