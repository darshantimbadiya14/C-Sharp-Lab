/*
    Definition 14
    Write a program to check weather a number is palindrome or not 
    e.g. input: 121, output: It is palindrome 
         input:124, output: It is not palindrome
*/

using System;
namespace Prog14
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine(originalNumber + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(originalNumber + " is not a palindrome.");
            }
        }
    }
}