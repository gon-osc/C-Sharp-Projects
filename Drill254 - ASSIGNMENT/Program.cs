using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill254___ASSIGNMENT
{
    class Program
    {
        public static void Main(string[] args)
        {

            try 
            {
                Console.WriteLine("Please select the current day of the week.");
                string userDay = Console.ReadLine();
                var inputDay = userDay;
                DayofWeek dayNames = (DayofWeek)Enum.Parse(typeof(DayofWeek), inputDay);
                Console.WriteLine("Today is {0}", inputDay);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");               
            }
     
            Console.ReadLine();
        }
        
        public enum DayofWeek
        {
            Sunday=1,
            Monday=2,
            Tuesday=3,
            Wednesday=4,
            Thursday=5,
            Friday=6,
            Saturday=7
        };
    }
}
