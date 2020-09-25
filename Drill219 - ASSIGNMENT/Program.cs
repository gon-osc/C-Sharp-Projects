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
            int Mtotal;

            double d = 42.35;
            double c = 99.99;
            double Dtotal;

            string f = "45";
            string g = "35";
            int num1 = Int32.Parse(f);
            int num2 = Int32.Parse(g);
            int Atotal;


            MathOperation n = new MathOperation();
            Mtotal = n.mult(a, b);
            Dtotal = n.Sub(c, d);
            Atotal = n.Add(num1, num2);


            Console.WriteLine("100 multiplied by 10 equal: {0}", Mtotal);
            Console.WriteLine("99.99 minus 45.99 equal: {0}", Dtotal);
            Console.WriteLine(f + " plus " +g+ " equal: {0}", Atotal);


            Console.ReadLine();
        }
    }
}
