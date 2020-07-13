using System;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.src.ApplicationCore
{
    class VectorBasedDrawingApplication
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 10, 30, 40);
            Shape square = new Square(15, 30, 35);
            Shape ellipse = new Ellipse(0, 0, 40, 20);
            Shape circle = new Circle(0, 0, 300);

            //rectangle.Draw();
            //square.Draw();
            //ellipse.Draw();
            //circle.Draw();
        }
    }
}
