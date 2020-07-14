namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get => _width;

            set
            {
                if (value >= 0)
                    _width = value;
            }
        }

        public int Height
        {
            get => _height;

            set
            {
                if (value >= 0)
                    _height = value;
            }
        }
    }
}
