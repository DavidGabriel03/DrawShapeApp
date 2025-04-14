using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Line : Shape, iDrawable, iMovable, iResizable
    {
        public int length { get; set; }
        public Line(int x, int y, int length) : base(x, y)
        {
            X = x;
            Y = y;
            this.length = length;
        }
        public override double Resize(float size)
        {
            length = (int)(length * size);
            return length;
        }
        public override void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, X, Y, length, length);
        }
    }
}
