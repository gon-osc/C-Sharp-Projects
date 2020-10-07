using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drill_303___ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            const string programName = "C#";

            var releaseYear = 2000;

            Console.WriteLine("{0} has evolved much since their first appearance in the year {1}. The current version of C# is 9.0.", programName, releaseYear);

            Console.WriteLine("First construct!");
            ConstructorChain a = new ConstructorChain(22);
            Console.WriteLine("Chain construct!");
            ConstructorChain b = new ConstructorChain(26 , "Daniel");

            Console.ReadLine();
        }

        
    }
}
