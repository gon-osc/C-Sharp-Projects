using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Drill290___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\gonza\Documents\Logs\Drill290.txt";
            Console.WriteLine("Please input a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter Nfile = new StreamWriter(@"C:\Users\gonza\Documents\Logs\Drill290.txt", true))
            {
                Nfile.WriteLine(userNumber);
            }
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                Console.WriteLine(str);
            }

            Console.WriteLine("The number you have chosen is {0}.", userNumber);
            Console.ReadLine();
        }
    }
}
