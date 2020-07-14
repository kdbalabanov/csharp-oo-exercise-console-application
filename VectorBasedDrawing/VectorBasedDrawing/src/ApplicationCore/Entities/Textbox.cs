using System;
using System.Collections.Generic;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public class Textbox : Rectangle
    {
        private string _text;

        public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height)
        {
            Text = text;
        }

        public string Text
        {
            get => _text ?? "";

            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _text = value;
            }
        }
    }
}
