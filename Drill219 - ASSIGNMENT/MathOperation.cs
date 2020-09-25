using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill219___ASSIGNMENT
{
    class MathOperation
    {
        public int mathOperation(int a, int b)
        {
            return a * b;   
        }
        public int mathOperation(decimal c, decimal d)
        {
            int e = decimal.ToInt32(c);
            int f = decimal.ToInt32(d);
            return  f - e;            
        }
        public int mathOperation(string g, string h)
        {            
            int num1 = Int32.Parse(g);
            int num2 = Int32.Parse(h);       
            return num1 + num2;
        }
    }
}
