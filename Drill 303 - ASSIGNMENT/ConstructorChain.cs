using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_303___ASSIGNMENT
{
    class ConstructorChain
    {
        public int studentAge;
        public string studentName;

        public ConstructorChain(int studentAge)
        {
            this.studentAge = studentAge;
            Console.WriteLine("" + studentAge);
        }
        public ConstructorChain(int studentAge, string studentName): this(studentAge)
        {
            this.studentName = studentName;
            Console.WriteLine("" + studentName);
        }
    }
}
