using System;

abstract class Triangle
{
    protected double a;
    protected double b;
    protected double angle; 

    public Triangle(double a, double b, double angle)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentException("Сторони трикутника повинні бути більші за нуль!");

        if (angle <= 0 || angle >= 180)
            throw new ArgumentException("Кут повинен бути в межах (0°, 180°)!");

        this.a = a;
        this.b = b;
        this.angle = angle;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}