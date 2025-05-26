using System;
namespace task3;
public class Circle
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    public Circle(double x, double y, double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным");
        X = x;
        Y = y;
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public bool ContainsPoint(double px, double py)
    {
        double dx = px - X;
        double dy = py - Y;
        return dx * dx + dy * dy <= Radius * Radius;
    }
}