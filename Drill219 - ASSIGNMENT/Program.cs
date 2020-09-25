using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill219___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {                       
            int a = 100;
            int b = 10;


            decimal c = 42.35m;
            decimal d = 99.99m;

            string g = "45";
            string h = "35";



            MathOperation n = new MathOperation();
            int Mtotal = n.mathOperation(a, b);
            int Dtotal = n.mathOperation(c, d);
            int Atotal = n.mathOperation(g, h);


            Console.WriteLine("100 multiplied by 10 equal: {0}", Mtotal);
            Console.WriteLine(d + " minus " + c + " equal: {0}", Dtotal);
            Console.WriteLine(g + " plus " + h + " equal: {0}", Atotal);


            Console.ReadLine();
        }
    }
}
