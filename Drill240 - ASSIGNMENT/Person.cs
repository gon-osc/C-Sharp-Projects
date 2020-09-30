using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill240___ASSIGNMENT
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
