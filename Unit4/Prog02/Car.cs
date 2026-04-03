using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car : Vehicle
    {
        string modelType, companyName;

        public void getCar()
        {
            Console.WriteLine("Enter the model type of the car");
            modelType = Console.ReadLine();

            Console.WriteLine("Enter the company name of the car");
            companyName = Console.ReadLine();
        }
        public void showCar()
        {
            Console.WriteLine("The model type of the car is: " + modelType);
            Console.WriteLine("The company name of the car is: " + companyName);
        }
    }
}