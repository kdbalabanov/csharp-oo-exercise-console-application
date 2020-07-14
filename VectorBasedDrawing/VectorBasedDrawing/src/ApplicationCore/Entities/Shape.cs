using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace VectorBasedDrawing.src.ApplicationCore.Entities
{
    public abstract class Shape : Widget
    {
        private int _x;
        private int _y;

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintDetails()
        {
            Type t = GetType();
            Console.Write("{0} ({1}, {2})", t.Name, X, Y);
            PropertyInfo[] props = t.GetProperties().Where(p => !"X".Equals(p.Name) && !"Y".Equals(p.Name)).ToArray();

            foreach (var prop in props)
                Console.Write(" {0} = {1}", prop.Name, prop.GetValue(this));

            Console.WriteLine("");
        }

        public int X
        {
            get => _x;

            set
            {
                if (value >= 0)
                    _x = value;
            }
        }

        public int Y
        {
            get => _y;

            set
            {
                if (value >= 0)
                    _y = value;
            }
        }
    }
}
