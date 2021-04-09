using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CompGraph
{
    public class Circle
    {
        public SolidBrush brush;
        private readonly Brush eraser = new SolidBrush(Color.White);

        public Graphics graphics { get; set; }

        public Circle(Graphics graphics, Color color)
        {
            this.graphics = graphics;

            brush = new SolidBrush(color);
        }

        public void Draw(int centerX, int centerY, int radius)
        {
            graphics.FillEllipse(brush, centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.DrawEllipse(new Pen(Color.Black, 2), centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        public void Erase(int centerX, int centerY, int radius)
        {
            graphics.FillEllipse(eraser, centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.DrawEllipse(new Pen(Color.White, 2), centerX - radius, centerY - radius, radius * 2, radius * 2);
        }
    }
}
