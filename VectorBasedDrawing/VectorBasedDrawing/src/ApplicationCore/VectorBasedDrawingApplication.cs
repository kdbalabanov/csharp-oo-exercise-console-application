using System;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.src.ApplicationCore
{
    class VectorBasedDrawingApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle rectangle = new Rectangle(0, 0, 10, 10);
            rectangle.Draw();
        }
    }
}
