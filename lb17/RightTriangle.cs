using System;

class RightTriangle : Triangle
{
    public RightTriangle(double a, double b, double angle)
        : base(a, b, angle)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentException("Сторони трикутника повинні бути більші за нуль!");

        if (Math.Abs(angle - 90) > 1e-6) 
            throw new ArgumentException("Для прямокутного трикутника кут між сторонами повинен бути 90°!");
    }

    public override double GetArea() => (a * b) / 2;

    public override double GetPerimeter()
    {
        double c = Math.Sqrt(a * a + b * b);
        return a + b + c;
    }
}