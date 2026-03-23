/*
    Definition 7
    Write a program to input age of person and display message as follows 
        - If age < 12 print You are Kid 
        - If age between 12 to 17 print You are teenager 
        - If age between 18 to 60 print you are Adult 
    If age > 60 print You are Senior Citizen
*/

using System;

namespace Prog07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(age);

            if (age < 12)
            {
                Console.WriteLine("You are Kid.");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("You are teenager.");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are Adult.");
            }
            else
            {
                Console.WriteLine("You are Senior Citizen.");
            }
        }
    }
}