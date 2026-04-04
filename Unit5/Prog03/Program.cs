/* 
  Definition 03
        Describe an abstract class called Shape which has three subclasses say Triangle,Rectangle,and Circle. 
        Define one method area () in the abstract class and override this area () in these three subclasses to 
        calculate for specific objects i.e., area () of Triangle subclass should calculate area
        of triangle etc. Same for Rectangle and Circle 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Shape t = new Triangle(10, 5);
        Shape r = new Rectangle(4, 6);
        Shape c = new Circle(3);

        Console.WriteLine("Triangle Area: " + t.area());
        Console.WriteLine("Rectangle Area: " + r.area());
        Console.WriteLine("Circle Area: " + c.area());

        Console.ReadLine();
    }
}