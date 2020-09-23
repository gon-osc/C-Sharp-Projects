using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill207___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>();
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(500);
            numbers.Add(700);
            numbers.Add(800);
            numbers.Add(1000);

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            

            try
            {
                Console.WriteLine("Pick a number to divide these number by.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                foreach (var num in numbers)
                {
                    int numberOne = Convert.ToInt32(num);

                    int numberThree = numberOne / numberTwo;
                    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                    
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero."); 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("This program has emerged from the try/catch block and continued on with program execution.");

            

        }
    }
}
