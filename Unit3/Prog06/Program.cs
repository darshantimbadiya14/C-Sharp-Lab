/*
    Definition 6
    Write a program to check the number is even or odd.
*/

using System;

namespace Prog06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}