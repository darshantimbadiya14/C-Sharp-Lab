/*
    Definition 2
    Write a program to input 2 number and an arithmetic  operator. Display the result accordingly. 
*/

using System;

namespace Prog02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num2 * addition;
            int division = num1 / num2;

            Console.WriteLine("Addition: " + addition
                              + "\nSubtraction: " + subtraction
                              + "\nMultiplication: " + multiplication
                              + "\nDivision: " + division);
        }
    }
}