/*
    Definition 11
    Write a program to find all prime numbers between two values inputted by the user.
*/

using System;

namespace Prog11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + num1 + " and " + num2 + ":");

            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}