/*
    Definition 5
    Write a program to input radius of a circle, and print area of 
    that circle.
*/

using System;

namespace Prog05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter radius of the circle: ");

            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Area of the circle: " + area);
        }
    }
}