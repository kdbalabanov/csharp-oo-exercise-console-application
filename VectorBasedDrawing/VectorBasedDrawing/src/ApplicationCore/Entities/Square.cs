using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Square : Rectangle
    {
        private int _size;

        public Square(int x, int y, int size) : base(x, y, size, size)
        {
            _size = Math.Abs(size);
        }

        public int Size
        {
            get => _size;

            set
            {
                if (value >= 0)
                    _size = value;
            }
        }
    }
}
