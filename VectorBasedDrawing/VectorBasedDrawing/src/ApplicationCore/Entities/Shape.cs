using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public abstract class Shape
    {
        private int _x;
        private int _y;

        public Shape(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public abstract void Draw();

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                if (value >= 0)
                {
                    _x = value;
                }
            }
        }

        public int Y
        {
            get
            { return _y; }

            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
            }
        }
    }
}
