using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class GraphicTool
    {
        public List<Shape> shapes { get; set; }
        public IShapeRepository shapeRepository { get; set; }
        public GraphicTool()
        {
            shapes = new List<Shape>();
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public void DrawShapes(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }
        public void MoveShapes(int dx, int dy)
        {
            foreach (Shape shape in shapes)
            {
                shape.Move(dx, dy);
            }
        }
        public void ResizeShapes(float size)
        {
            foreach (Shape shape in shapes)
            {
                shape.Resize(size);
            }
        }
        public void SaveShapes()
        {
            shapeRepository.SaveShapes(shapes);
        }
        public void LoadShapes()
        {
            shapes = shapeRepository.LoadShapes();
        }
    }
}
