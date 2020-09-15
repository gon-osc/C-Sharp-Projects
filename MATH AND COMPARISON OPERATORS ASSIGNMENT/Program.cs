using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH_AND_COMPARISON_OPERATORS_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int user1HoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int user1HourlyRate = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int user2HoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int user2HourlyRate = Convert.ToInt32(Console.ReadLine());

            int user1AnnualSalary = user1HourlyRate * user1HoursWorked * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(user1AnnualSalary);

            int user2AnnualSalary = user2HourlyRate * user2HoursWorked * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(user2AnnualSalary);

            bool annualSalaaryComparison = user1AnnualSalary > user2AnnualSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalaaryComparison);
            Console.ReadLine();
        }
    }
}
