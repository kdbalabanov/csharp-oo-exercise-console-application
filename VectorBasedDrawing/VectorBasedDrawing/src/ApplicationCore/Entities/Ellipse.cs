using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Ellipse : Shape
    {
        private int _horizontalDiameter;
        private int _horizontalRadius;
        private int _verticalDiameter;
        private int _verticalRadius;

        public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
        {
            _horizontalDiameter = horizontalDiameter;
            _horizontalRadius = _horizontalDiameter / 2;
            _verticalDiameter = verticalDiameter;
            _verticalRadius = _verticalDiameter / 2;
        }

        override
        public void Draw()
        {
            double distance;

            for (int i = 0; i <= _horizontalDiameter; i++)
            {

                // for vertical movement 
                for (int j = 0; j <= _verticalDiameter; j++)
                {
                    distance = Math.Sqrt((i - _horizontalRadius) * (i - _horizontalRadius) + (j - _verticalRadius) * (j - _verticalRadius));

                    if ((distance > _horizontalRadius - 0.5 && distance < _horizontalRadius + 0.5) && (distance > _verticalRadius - 0.5 && distance < _verticalRadius + 0.5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine("");
            }

        }

        public int HorizontalD
        {
            get { return _horizontalDiameter; }

            set
            {
                if (value > 0)
                {
                    _horizontalDiameter = value;
                }
            }
        }

        public int VerticalD
        {
            get { return _verticalDiameter; }

            set
            {
                if (value > 0)
                {
                    _verticalDiameter = value;
                }
            }
        }
    }
}
