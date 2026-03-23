/*
    Definition 13
    Write a program to find minimum of three numbers using conditional operator
*/

using System;

namespace Prog13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter three numbers to find the minimum:");

            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int min = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);

            Console.WriteLine("The minimum of the three numbers is: " + min);
        }
    }
}