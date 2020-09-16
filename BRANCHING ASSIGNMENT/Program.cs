using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCHING_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
     
            if (weight >= 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else
            {
                Console.WriteLine("please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");

                int length = Convert.ToInt32(Console.ReadLine());

                int packageDimension = width + height + length;
                int packagePricing = width * height * length * weight / 100;

                string dimensions = packageDimension > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: $" + String.Format("{0:0.00}", packagePricing);

                Console.WriteLine(dimensions);
            }
            
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}
