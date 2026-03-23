
/*
    Definition 18
    Write a program to display maximum number from 5 
    numbers inputted by user by using the concept of arrays   
*/

using System;

namespace Prog18
{
    class Program
    {
        static void Main()
        {

            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("The maximum number is: " + max);
        }
    }
}
