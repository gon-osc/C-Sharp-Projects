using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill245___ASSIGNMENT
{
    class Employee: Person
    {   
        public int Id { get; set; }
        
        public static bool operator ==(Employee employee, Person person)
        {
            if (employee.Id == employee.Id)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Person person)
        {
            if (employee.Id != employee.Id)
                return true;
            else
                return false;
        }
        public int getValue()
        {
            return Id;
        }


        public override void SayName()
        {
            Console.WriteLine("Welcome");           
            base.SayName();
            Console.WriteLine("Employee ID: {0}", Id);
        }
        public void Quit()
        {
            Console.WriteLine("We wish the best!!! Thank you for the years you put into this company...");
        }
    }
}
