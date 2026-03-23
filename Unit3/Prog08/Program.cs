/*
    Definition 8
    Write a program to find factorial of a given number.
*/

using System;

namespace Prog08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number to find its factorial: ");

            int number = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }
}