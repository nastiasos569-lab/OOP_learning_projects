using System;
using System.Drawing;

namespace Lb16
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() : base()
        {
            Radius = 30;
        }

        public Circle(double r) : base(100, 100)
        {
            Radius = r;
        }

        public Circle(double x, double y, double r) : base(x, y)
        {
            Radius = r;
        }

        public void Resize(double factor)
        {
            Radius *= factor;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Blue,
                (float)X,
                (float)Y,
                (float)Radius * 2,
                (float)Radius * 2);
        }
    }
}