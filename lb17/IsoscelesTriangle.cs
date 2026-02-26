using System;

class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double a, double b, double angle)
        : base(a, b, angle)
    {
        double rad = angle * Math.PI / 180;
        double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(rad));
        if (c <= 0)
            throw new ArgumentException("Неможливо побудувати трикутник з такими сторонами та кутом!");
    }

    public override double GetArea()
    {
        double rad = angle * Math.PI / 180;
        return 0.5 * a * b * Math.Sin(rad); 
    }

    public override double GetPerimeter()
    {
        double rad = angle * Math.PI / 180;
        double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(rad));
        return a + b + c;
    }
}