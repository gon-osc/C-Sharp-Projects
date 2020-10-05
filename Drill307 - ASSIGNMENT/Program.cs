using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Drill307___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentYear = DateTime.Now;
            Console.WriteLine("How old are you?");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                DateTime yearBorn = currentYear.AddYears(-userAge);
                string BirthYear = yearBorn.ToString("yyyy");
                Method(userAge, 1);
                Console.WriteLine("You were born in {0}", BirthYear);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a whole number");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        public static int Method(int a, int b)
        {
            if (b > a) throw new ArgumentException("Please input a number that greater than 0. No negative numbers allowed.");
            return 0;
        }
    }
}
