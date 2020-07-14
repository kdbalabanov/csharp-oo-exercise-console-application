using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Ellipse : Shape
    {
        private int _horizontalDiameter;
        private int _verticalDiameter;

        public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public int HorizontalDiameter
        {
            get => _horizontalDiameter;

            set
            {
                if (value > 0)
                    _horizontalDiameter = value;
            }
        }

        public int VerticalDiameter
        {
            get => _verticalDiameter;

            set
            {
                if (value > 0)
                    _verticalDiameter = value;
            }
        }
    }
}
