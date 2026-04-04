using Prog03;
using System;

class Triangle : Shape
{
    double baseVal, height;

    public Triangle(double b, double h)
    {
        baseVal = b;
        height = h;
    }

    public override double area()
    {
        return 0.5 * baseVal * height;
    }
}