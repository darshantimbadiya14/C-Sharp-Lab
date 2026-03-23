/*
   Definition 19
   Write a program to display minimum number from 5 
   numbers inputted by user by using the concept of arrays   
*/

using System;
namespace Prog19
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

            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("The minimum number is: " + min);
        }
    }
}