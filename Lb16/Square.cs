using System.Drawing;

namespace Lb16
{
    public class Square : RectangleShape
    {
        public Square(double side) : base(side, side)
        {
        }
        public Square(double x, double y, double side)
            : base(x, y, side, side)
        {
        }
    }
}