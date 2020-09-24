using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill216___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number you want to do the math operations on.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int a = userNumber;
            int b = 100;
            int Stotal;
            int Mtotal;
            int Dtotal;

            MathOperations n = new MathOperations();       
            Stotal = n.sum(a, b);
            Mtotal = n.mult(a, b);
            Dtotal = n.div(a, b);

            Console.WriteLine("100 plus " + a + " equals : {0}", Stotal);
            
            Console.WriteLine("100 multiplied by " + a + " equal: {0}", Mtotal);
            
            Console.WriteLine("100 divided by " + a + " equal: {0}", Dtotal);
            
            Console.ReadLine();
        }
    }
}
