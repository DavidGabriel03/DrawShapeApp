using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public abstract double Resize(float size);
        public abstract void Move(int dx, int dy);
        public abstract void Draw(Graphics g);
    }
}
