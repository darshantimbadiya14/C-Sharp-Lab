
/*
    Definition 16
    Write a program to check whether a number is Armstrong or not 
    e.g. Input:153 output: It is Armstrong 
    e.g. Input:100 output: It is not Armstrong  
*/

using System;
namespace Prog16
{
    class Program
    {
        static void Main()
        {

            int num, sum = 0, temp, remainder;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (temp != 0)
            {
                remainder = temp % 10;
                sum += remainder * remainder * remainder;
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine(num + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(num + " is not an Armstrong number.");
            }
        }
    }
}
