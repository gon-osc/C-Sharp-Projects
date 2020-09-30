using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill265___ASSIGNMENT
{
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }

        public Employee(string Fname, string Lname, int ID)
        {
            FName = Fname;
            LName = Lname;
            Id = ID;
        }  
    }
}
