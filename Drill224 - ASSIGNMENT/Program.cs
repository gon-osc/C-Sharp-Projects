using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill224___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Division n = new Division();

            Console.WriteLine("Division");
            Console.WriteLine("Pick a number to do divide in half.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            n.Div(userNumber);

            Console.WriteLine("Pick a number to do divide in half.");
            decimal userNumber2 = decimal.Parse(Console.ReadLine());           
            n.Div(userNumber2);

            int a = 25;
            Console.WriteLine("Before Output Method called value of a was: {0}", a);
            n.getNumber(out a);
            Console.WriteLine("After Output Method called value of a is now: {0}", a);

            Console.WriteLine("This was called from within a static class: {0} ", Example.phrase);

            Console.ReadLine();
        }
    }
}
