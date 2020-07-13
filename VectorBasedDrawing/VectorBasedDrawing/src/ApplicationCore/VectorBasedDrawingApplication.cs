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

            rectangle.Draw();
            square.Draw();
        }
    }
}
