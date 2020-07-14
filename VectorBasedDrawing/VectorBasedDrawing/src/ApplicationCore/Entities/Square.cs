namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Square : Shape
    {
        private int _size;

        public Square(int x, int y, int size) : base(x, y)
        {
            Size = size;
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
