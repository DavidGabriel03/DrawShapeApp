using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Rectangle : Shape, iDrawable, iMovable, iResizable
    {
        public float width { get; set; }
        public float height { get; set; }
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
        }
        public override double Resize(float size)
        {
            width = width * size;
            height = height * size;
            return width;
            return height;
        }
        public override void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, width, height);
        }
    }
}
