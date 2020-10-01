using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill265___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Joe", "Smith", 1));
            employees.Add(new Employee("Jack", "Cantrall", 2));
            employees.Add(new Employee("Jonah", "Backhus", 3));
            employees.Add(new Employee("Mike", "Stone", 4));
            employees.Add(new Employee("Joe", "Rogers", 5));
            employees.Add(new Employee("Nick", "Radden", 6));
            employees.Add(new Employee("Bill", "Tadeo", 7));
            employees.Add(new Employee("Jim", "Eason", 8));
            employees.Add(new Employee("Mark", "Udell", 9));
            employees.Add(new Employee("Tim", "Packer", 10));

            List<Employee> dupEmp = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FName == "Joe")
                {
                    dupEmp.Add(employee);
                }
            }
            foreach (Employee employee1 in dupEmp)
            {
                Console.WriteLine(employee1.FName +" "+ employee1.LName +" "+employee1.Id);
            }
            Console.ReadLine();


            List<Employee> dupemp2 = employees.Where(x => x.FName == "Joe").ToList();
            foreach (Employee dupemployee2 in dupemp2)
            {
                Console.WriteLine(dupemployee2.FName + " " + dupemployee2.LName + " " + dupemployee2.Id);
            }
            Console.ReadLine();


            List<Employee> greaterEmp = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee2 in greaterEmp)
            {
                Console.WriteLine(employee2.FName + " " + employee2.LName + " " + employee2.Id);
            }

            Console.ReadLine();

        }
    }
}
