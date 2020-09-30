using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill240___ASSIGNMENT
{
    class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Welcome");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("We wish the best!!! Thank you for the years you put into this company...");
        }
    }
}
