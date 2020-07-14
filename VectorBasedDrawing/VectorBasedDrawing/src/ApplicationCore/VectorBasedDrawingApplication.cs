using System;
using System.Collections.Generic;
using System.Reflection;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.src.ApplicationCore
{
    class VectorBasedDrawingApplication
    {
        static void Main(string[] args)
        {
            var drawing = new List<Widget>();
            drawing.Add(new Rectangle(10, 10, 30, 40));
            drawing.Add(new Square(15, 30, 35));
            drawing.Add(new Ellipse(100, 150, 300, 200));
            drawing.Add(new Circle(1, 1, 300));
            drawing.Add(new Textbox(5, 5, 200, 100, "sample text"));


            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");
            foreach (var widget in drawing)
            {
                widget.PrintDetails();
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
