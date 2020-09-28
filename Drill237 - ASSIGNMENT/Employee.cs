using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill237___ASSIGNMENT
{
    class Employee:Person
    {
        public override void SayName()
        {
            Console.WriteLine("Welcome");
            base.SayName();
        }
    }
}
