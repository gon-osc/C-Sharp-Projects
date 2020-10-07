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
            Console.WriteLine("Creating a new record for a new student, using the student age {0}", studentAge);
        }
        public ConstructorChain(int studentAge, string studentName)
        {
            this.studentName = studentName;
            this.studentAge = studentAge;
            Console.WriteLine("Creating a new record for a new student, using the Student Name: {0} and Student Age: {1}", studentName, studentAge);
        }



    }
}
