using System;
using System.Drawing;

namespace Lb16
{
    public class RectangleShape : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleShape() : base()
        {
            Width = 60;
            Height = 40;
        }

        public RectangleShape(double w, double h) : base(200, 150)
        {
            Width = w;
            Height = h;
        }

        public RectangleShape(double x, double y, double w, double h) : base(x, y)
        {
            Width = w;
            Height = h;
        }

        public void Resize(double factor)
        {
            Width *= factor;
            Height *= factor;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override void Draw(Graphics g)
        {
            g.TranslateTransform(
                (float)(X + Width / 2),
                (float)(Y + Height / 2));

            g.RotateTransform(Angle);

            g.DrawRectangle(
                Pens.Red,
                (float)(-Width / 2),
                (float)(-Height / 2),
                (float)Width,
                (float)Height);

            g.ResetTransform();
        }
    }
}