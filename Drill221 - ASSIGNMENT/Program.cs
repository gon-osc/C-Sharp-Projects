using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill221___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations n = new MathOperations();

            Console.WriteLine("Addition");
            Console.WriteLine("Pick two number to add");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           

            n.Sum(firstNumber, secondNumber);

            n.Sum(first: 5, second: 9);

            



            Console.ReadLine();
        }
    }
}
