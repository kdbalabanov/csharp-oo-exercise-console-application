using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        override
        public void Draw()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public int Width
        {
            get { return _width; }

            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
            }
        }

        public int Height
        {
            get { return _height; }

            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
            }
        }
    }
}
