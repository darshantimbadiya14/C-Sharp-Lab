
/*
    Definition 4
    Write a program to input principal amount, rate and year and display the compound interest.
*/

using System;

namespace Prog04
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

            double compoundInterest = principal * Math.Pow((1 + rate / 100), time) - principal;

            Console.WriteLine("Compound Interest: " + compoundInterest);
        }
    }
}
