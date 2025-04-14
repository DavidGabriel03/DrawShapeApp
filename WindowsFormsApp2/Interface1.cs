using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public interface iDrawable
    {
        void Draw(Graphics g);
    }
    public interface iMovable
    {
         void Move(int dx, int dy);
    }
    public interface iResizable
    {
        double Resize(float size);
    }
    public interface IShapeRepository
    {
        void SaveShapes(List<Shape> shapes);
        List<Shape> LoadShapes();
    }
}
