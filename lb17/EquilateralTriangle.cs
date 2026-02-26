using System;

class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double a, double b, double angle)
        : base(a, b, angle)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentException("Сторони трикутника повинні бути більші за нуль!");
        if (Math.Abs(a - b) > 1e-6)
            throw new ArgumentException("Сторони рівностороннього трикутника повинні бути рівні!");
        if (Math.Abs(angle - 60) > 1e-6)
            throw new ArgumentException("Кут рівностороннього трикутника повинен бути 60°!");
    }

    public override double GetArea() => (a * a * Math.Sqrt(3)) / 4;
    public override double GetPerimeter() => 3 * a;
}