using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        /// <summary>  
        /// Fields  
        /// </summary>  

        bool painting = false;
        int index = 1;
        int x, y, sX, sY, cX, cY;
        Color colorP;
        Point pointX, pointY;
        Bitmap bitmapN;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 2);
        Pen Eraser = new Pen(Color.White, 10);
        enum ShapeType { None, Rectangle, Circle, Line, Triangle,Eraser }
        ShapeType currentShape = ShapeType.None;

        //Methods  
        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Width / pictureBox.Image.Width;
            float pY = 1f * pictureBox.Height / pictureBox.Image.Height;

            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }
        public Form1()
        {
            InitializeComponent();
            bitmapN = new Bitmap(Pic.Width, Pic.Height); // Use 'this' to reference the current instance of the form    
            graphics = Graphics.FromImage(bitmapN);
            graphics.Clear(Color.White);
            Pic.Image = bitmapN;
            Pic.MouseDown += Pic_MouseDown;
            Pic.MouseUp += Pic_MouseUp;
            Pic.MouseMove += Pic_MouseMove;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Rectangle;
            painting = false;
            sX = x - cX;
            sY = y - cY;

            graphics.DrawRectangle(pen, cX, cY, x, y);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Triangle;
            painting = false;
            sX = x - cX;
            sY = y - cY;
            graphics.DrawRectangle(pen, cX, cY, sX, sY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            if (!painting) return;

            int tempSX = x - cX;
            int tempSY = y - cY;

            switch (currentShape)
            {
                case ShapeType.Rectangle:
                    e.Graphics.DrawRectangle(pen, Math.Min(cX, x), Math.Min(cY, y), Math.Abs(tempSX), Math.Abs(tempSY));
                    break;
                case ShapeType.Circle:
                    e.Graphics.DrawEllipse(pen, Math.Min(cX, x), Math.Min(cY, y), Math.Abs(tempSX), Math.Abs(tempSY));
                    break;
                case ShapeType.Line:
                    e.Graphics.DrawLine(pen, cX, cY, x, y);
                    break;
                case ShapeType.Triangle:
                    Point point1 = new Point((cX + x) / 2, cY);
                    Point point2 = new Point(cX, y);
                    Point point3 = new Point(x, y);
                    e.Graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    break;
            }
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Circle;
            painting = false;
            sX = x - cX;
            sY = y - cY;
            graphics.DrawEllipse(pen, cX, cY, sX, sY);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Line;
            painting = false;
            sX = x - cX;
            sY = y - cY;
            graphics.DrawLine(pen, cX, cY, sX, sY);

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {

        }

        private void buttonResize_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmapN.Save(saveFileDialog.FileName);
            }

        }

           private void buttonErase_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Eraser;
        }
        

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            painting = true;
            cX = e.X;
            cY = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (painting)
            {
                x = e.X;
                y = e.Y;
                if (currentShape == ShapeType.Eraser)
                {
                    // "Șterge" cu o pensulă albă groasă
                    graphics.FillEllipse(Brushes.White, x - 10, y - 10, 20, 20);
                    Pic.Invalidate();
                }
                else
                {
                    Pic.Refresh(); // Triggers Paint for live shape preview
                }
            }
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            painting = false;
            x = e.X;
            y = e.Y;

            sX = x - cX;
            sY = y - cY;

            switch (currentShape)
            {
                case ShapeType.Rectangle:
                    graphics.DrawRectangle(pen, Math.Min(cX, x), Math.Min(cY, y), Math.Abs(sX), Math.Abs(sY));
                    break;
                case ShapeType.Circle:
                    graphics.DrawEllipse(pen, Math.Min(cX, x), Math.Min(cY, y), Math.Abs(sX), Math.Abs(sY));
                    break;
                case ShapeType.Line:
                    graphics.DrawLine(pen, cX, cY, x, y);
                    break;
                case ShapeType.Triangle:
                    Point point1 = new Point((cX + x) / 2, cY);      // Top  
                    Point point2 = new Point(cX, y);                 // Bottom left  
                    Point point3 = new Point(x, y);                  // Bottom right  
                    graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    break;
            }

            Pic.Invalidate();
        }
    }
}
