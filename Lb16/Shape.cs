using System.Drawing;

namespace Lb16
{
    public abstract class Shape
    {
        public static int ObjectCount = 0;

        public double X { get; set; }
        public double Y { get; set; }
        public float Angle { get; set; }

        public Shape()
        {
            ObjectCount++;
        }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
            ObjectCount++;
        }

        public virtual void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public virtual void Rotate(float angle)
        {
            Angle += angle;   // накопичуємо поворот
        }

        public abstract void Draw(Graphics g);
        public abstract double Area();
    }
}