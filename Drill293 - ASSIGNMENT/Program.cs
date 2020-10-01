using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Drill293___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            
            Console.WriteLine("Please input a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            DateTime futTime = date1.AddHours(userNumber);
            Console.WriteLine("Based on you number it will be {0} in {1} hours.", futTime, userNumber);
            
            Console.ReadLine();
        }
    }
}
