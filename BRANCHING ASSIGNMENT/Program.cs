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
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            string results = packageWeight > 50 ? "Package too heavy to be shipped via Package Express.Have a good day." : "please enter the package width:" ;

            Console.WriteLine(results);
   
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");

            int packageLength = Convert.ToInt32(Console.ReadLine());

            int packageDimension = packageWidth * packageHeight * packageLength * packageWeight;
            int shippingTotal = packageDimension / 100;

            string dimensions = packageWidth > 50 || packageHeight > 50 || packageLength > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: $" + String.Format("{0:0.00}", shippingTotal);

            Console.WriteLine(dimensions);
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}
