using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // This is a class that represents a triangle shape. It inherits from the Shape class and implements the iDrawable, iMovable, and iResizable interfaces.
    // The class has properties for the side length of the triangle and its position (X, Y).
    // It includes methods to resize, move, and draw the triangle on a graphics object.
    // The Resize method scales the side length by a given factor, Move changes the position of the triangle, and Draw renders the triangle on the provided graphics context.
    // The constructor initializes the triangle's position and side length.

    public class Triangle : Shape, iDrawable, iMovable, iResizable
    {
        public int side { get; set; }
        public Triangle(int x, int y, int side) : base(x, y)
        {
            X = x;
            Y = y;
            this.side = side;
        }
        public override double Resize(float size)
        {
            side = (int)(side * size);
            return side;
        }
        public override void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[3];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + side, Y);
            points[2] = new Point(X + (side / 2), Y - (int)(Math.Sqrt(3) / 2 * side));
            g.DrawPolygon(Pens.Black, points);
        }
    }
}
