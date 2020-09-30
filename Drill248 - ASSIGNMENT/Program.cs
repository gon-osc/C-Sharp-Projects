using System;
using System.Collections.Generic;

namespace Drill248___ASSIGNMENT
{
    class Program
    {
        public static void Main()
        {
            
            
            
            Employee<string> company = new Employee<string>();
            company.AddToList("Computer Code");
            company.AddToList("Fax Machine Code");
            company.AddToList("Gate Code");
            company.AddToList("Vault Code");

            Employee<int> AccessCodes = new Employee<int>();
            AccessCodes.AddToList(7984);
            AccessCodes.AddToList(4367);
            AccessCodes.AddToList(9085);
            AccessCodes.AddToList(6590);

            company.DisplayList();
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
