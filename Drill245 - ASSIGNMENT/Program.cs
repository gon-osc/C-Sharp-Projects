using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill245___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee { FirstName = "John", LastName = "West", Id = 500 };
            Employee p2 = new Employee { FirstName = "Adam", LastName = "West", Id = 500 };

            if (p1.Id == p2.Id)
                Console.WriteLine("Employee's have the same Id number.");
            else
                Console.WriteLine("Employee's Id numbers are not the same.");
            Console.ReadLine();
        }
    }
}
