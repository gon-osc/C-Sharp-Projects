using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APPLICATION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number you would like to multiply by 50.");
            long userNumber = Convert.ToInt32(Console.ReadLine());
            long total = userNumber * 50;
            Console.WriteLine(" 50 * " + userNumber + " = " + total );
            

            Console.WriteLine("Input a number you would like to add 25 to.");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            int addtotal = addNumber + 25;
            Console.WriteLine(addNumber + " + 25 = " + addtotal);
            

            Console.WriteLine("Input a number you would like to divide by 12.5");
            double quotientNumber = Convert.ToInt32(Console.ReadLine());
            double quotientTotal = quotientNumber  / 12.5;
            Console.WriteLine( quotientNumber + " / 12.5 = " + quotientTotal);


            Console.WriteLine("Input a number you would like to check if it is greater than 50");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = userInput > 50;
            Console.WriteLine(trueOrFalse);
            

            Console.WriteLine("Input a number you would like to divide by 7 and get the remainder");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = userInputNumber % 7;
            Console.WriteLine(userInputNumber + " / 7 = " + remainder);
            Console.ReadLine();

        }
    }
}
