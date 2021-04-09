using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph
{
    public partial class Form1 : Form
    {
        public Graphics graphics;

        private Line line;
        private Polygon polygon;
        private RightPolygon rightPolygon;
        private Circle circle;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }


        private void drawLine_Click(object sender, EventArgs e)
        {
            line = new Line(graphics, Color.Red, 2);

            line.Draw(int.Parse(lineX0.Text), int.Parse(lineY0.Text), int.Parse(lineX1.Text), int.Parse(lineY1.Text));
        }

        private void clearLine_Click(object sender, EventArgs e)
        {
            if (line != null)
            {
                line.Erase(int.Parse(lineX0.Text), int.Parse(lineY0.Text), int.Parse(lineX1.Text), int.Parse(lineY1.Text));
                line = null;
            }
        }


        private void drawPolygon_Click(object sender, EventArgs e)
        {
            polygon = new Polygon(graphics, Color.Red);

            polygon.Draw(getPointsForPolygon());
        }

        private void clearPolygon_Click(object sender, EventArgs e)
        {
            if (polygon != null)
            {
                polygon.Erase(getPointsForPolygon());
                polygon = null;
            }
        }

        private PointF[] getPointsForPolygon()
        {
            var xCords = cordsX.Text.Split(';');
            var yCords = cordsY.Text.Split(';');

            PointF[] points = new PointF[xCords.Length];

            for (int i = 0; i < xCords.Length; i++)
            {
                points[i] = new PointF(Int32.Parse(xCords[i]), Int32.Parse(yCords[i]));
            }
            return points;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            rightPolygon = new RightPolygon(graphics, Color.Red);

            rightPolygon.Draw(getPointsForRightPolygon(Int32.Parse(number.Text), 50, Int32.Parse(firstPointX.Text), Int32.Parse(firstPointY.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rightPolygon != null)
            {
                rightPolygon.Erase(getPointsForRightPolygon(Int32.Parse(number.Text), 50, Int32.Parse(firstPointX.Text), Int32.Parse(firstPointY.Text)));
                rightPolygon = null;
            }
        }

        private PointF[] getPointsForRightPolygon(int size, int radius, int firstPointX, int firstPointY)
        {
            PointF[] points = new PointF[size];

            int centerX = firstPointX;
            int centerY = firstPointY + 50;

            double angle = 3 * Math.PI / 2;

            for (int i = 0; i < size; i++)
            {
                int X = (int)(centerX + Math.Round(radius * Math.Cos(angle + 2 * Math.PI * i / size)));
                int Y = (int)(centerY + Math.Round(radius * Math.Sin(angle + 2 * Math.PI * i / size)));

                points[i] = new PointF(X, Y);
            }

            return points;
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            circle = new Circle(graphics, Color.Red);

            int radius = Int32.Parse(circleRadius.Text);
            int centerX = Int32.Parse(circleCenterX.Text);
            int centerY = Int32.Parse(circleCenterY.Text);

            circle.Draw(centerX, centerY, radius);

            graphics.DrawString("Circle", new Font("Arial", radius / 5), new SolidBrush(Color.Black), centerX - radius / 3, centerY - radius / 10);
        }

        private void clearCircle_Click(object sender, EventArgs e)
        {
            if (circle != null)
            {
                circle.Erase(Int32.Parse(circleCenterX.Text), Int32.Parse(circleCenterY.Text), Int32.Parse(circleRadius.Text));
                circle = null;
            }
        }
    }
}
