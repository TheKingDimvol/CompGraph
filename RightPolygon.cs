using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CompGraph
{
    public class RightPolygon
    {
        public Brush brush;
        private readonly Brush eraser = new SolidBrush(Color.White);

        public Graphics graphics { get; set; }

        public RightPolygon(Graphics graphics, Color color)
        {
            this.graphics = graphics;
            brush = new SolidBrush(color);
        }

        public void Draw(PointF[] points)
        {
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(new Pen(Color.Black, 2), points);
        }

        public void Erase(PointF[] points)
        {
            graphics.FillPolygon(eraser, points);
            graphics.DrawPolygon(new Pen(Color.White, 2), points);
        }
    }
}
