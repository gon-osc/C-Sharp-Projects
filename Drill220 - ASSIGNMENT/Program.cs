using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill220___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {         
            MathOperation n = new MathOperation();

            Console.WriteLine("Multiplication");
            Console.WriteLine("Pick the first number");
            int firstNumber =  Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Pick the second number to multiply by... Unless otherwise leave empty and our default number will be selected");
            var sNumberIsValid = int.TryParse(Console.ReadLine(), out int sNumber);

            int total;
            if (sNumberIsValid)
            {
                total = n.multNumber(firstNumber, sNumber);
                Console.WriteLine(firstNumber + " * " + sNumber + " is: {0} ", total);
            }
            else
            {
                total = n.multNumber(firstNumber);
                Console.WriteLine(firstNumber + " * 6 total is: {0} ", total);
            }
                        
            ;


            Console.ReadLine();
        }
    }
}
