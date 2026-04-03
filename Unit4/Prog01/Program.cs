/* 
    Definition 01
        Create a class “Rectangle” that would contain length and width as an instance variable, 
        define constructors [constructor overloading (default, parameterized)]to initialize variables 
        of objects. Define methods to find area and to display variables value of objects which are created.
*/

using System;
using System.Drawing;

namespace Program01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Calculate();
            rectangle.Display();

            Rectangle rectangle_p = new Rectangle(20, 40);
            rectangle_p.Calculate();
            rectangle_p.Display();
        }
    }
}
