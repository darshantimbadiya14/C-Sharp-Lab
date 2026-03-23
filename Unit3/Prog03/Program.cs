/*
    Definition 3
    Write a program to input principal amount, rate and year and display the simple interest.
*/

using System;

namespace Prog03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter principal amount: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter rate of interest (in %): ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter time period (in years): ");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("Simple Interest: " + simpleInterest);
        }
    }
}