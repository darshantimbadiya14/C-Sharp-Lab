using System;

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double area()
    {
        return length * width;
    }
}