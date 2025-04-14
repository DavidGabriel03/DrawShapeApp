using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Circle : Shape , iDrawable, iMovable, iResizable
    {
        public int radius { get; set; } 
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public override double Resize(float size)
        {
            radius = (int)(radius * size);
            return radius;
        }
        public override void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
        public override void Draw(Graphics g)
        {
            
        }


    }

}
