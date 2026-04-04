/* 
  Definition 04
        Write a program to implement an interface called Exam with a method Pass (intmark) 
        that returns a boolean. Write another interface called Classify with a methodDivision (int average) 
        which returns a String. Write a class called Result which implements both Exam and Classify. The Pass
        method should return true if the mark is greater than or equal to 50 else false. The Division method 
        must return “First” when the parameter average is 60 or more, “Second” when average is50 or more but 
        below 60, “No division” when average is less than 50 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Result r = new Result();

            int marks, avg;

            Console.Write("Enter Marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Average: ");
            avg = Convert.ToInt32(Console.ReadLine());


            if (r.Pass(marks))
                Console.WriteLine("Result: Pass");
            else
                Console.WriteLine("Result: Fail");


            Console.WriteLine("Division: " + r.Division(avg));

            Console.ReadLine();
        }
    }
}