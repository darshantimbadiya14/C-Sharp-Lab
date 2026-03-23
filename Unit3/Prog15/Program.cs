/*
    Definition 15
    Write a program to check weather a string is palindrome or not 
    e.g. input:nayan output: it is palindrome 
    e.g. input: virat output: it is not palindrome 
*/

using System;
namespace Prog15
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(input + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome.");
            }
        }
    }
}