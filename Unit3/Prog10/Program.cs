/*
    Definition 10
    Write a program to check weather a number inputted by user is prime or not.
*/

using System;
namespace Prog10

{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}