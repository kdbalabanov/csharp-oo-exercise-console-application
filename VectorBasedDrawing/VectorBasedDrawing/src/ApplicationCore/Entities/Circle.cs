using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Circle : Ellipse
    {
        private int _diameter;

        public Circle(int x, int y, int diameter) : base(x, y, diameter, diameter)
        {
            _diameter = diameter;
        }

        public int Diameter
        {
            get { return _diameter; }

            set
            {
                if (value >= 0)
                {
                    _diameter = value;
                }
            }
        }
    }
}
