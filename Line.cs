using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CompGraph
{
    public class Line
    {
        public Pen pen;
        private readonly Pen eraser;

        public Graphics graphics { get; set; }

        public Line(Graphics graphics, Color color, int width)
        {
            this.graphics = graphics;

            pen = new Pen(color, width);

            //Раскомментить строку ниже для пунктира
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            eraser = new Pen(Color.White, width);
        }

        public void Draw(int X0, int Y0, int X1, int Y1)
        {
            graphics.DrawLine(pen, X0, Y0, X1, Y1);
        }

        public void Erase(int X0, int Y0, int X1, int Y1)
        {
            graphics.DrawLine(eraser, X0, Y0, X1, Y1);
        }
    }
}
