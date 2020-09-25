using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill224___ASSIGNMENT
{
    class Division
    {
        public void Div(int userNumber)
        {
            Console.WriteLine("Sum result: {0}", userNumber / 2);
        }
        public void Div(decimal userNumber)
        {
            Console.WriteLine("Sum result: {0}", userNumber / 2);
        }
        public void getNumber(out int a)
        {
            int temp = 9;
            a = temp;
        }
    }
    static class Example
    {
        public static string phrase = "Static classes are sealed, means one cannot inherit a static class from another class.";
    }
}
