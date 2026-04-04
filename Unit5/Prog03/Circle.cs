using System;

class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double area()
    {
        return 3.14 * radius * radius;
    }
}