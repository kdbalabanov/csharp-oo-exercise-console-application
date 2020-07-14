using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Circle : Shape
    {
        private int _diameter;

        public Circle(int x, int y, int diameter) : base(x, y)
        {
            Diameter = diameter;
        }

        public int Diameter
        {
            get => _diameter;

            set
            {
                if (value >= 0)
                    _diameter = value;
            }
        }
    }
}
