/*
    Definition 9
    Write a program to find Fibonacci series up to a number inputted by user.
*/

using System;

namespace Prog09 {
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("Enter a number to generate Fibonacci series up to that number: ");
            
            int limit = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            
            Console.WriteLine("Fibonacci series up to " + limit + ":");
            
            while (a <= limit) {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}