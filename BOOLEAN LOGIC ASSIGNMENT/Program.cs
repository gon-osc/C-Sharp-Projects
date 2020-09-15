using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEAN_LOGIC_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualification Questions");

            Console.WriteLine("What is your age?");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false'");
            string userDui = Console.ReadLine();
            bool userInput = Convert.ToBoolean(userDui);

            Console.WriteLine("How many speeding tickets do you have??");
            int clientTickets = Convert.ToInt32(Console.ReadLine());

            bool insApproval = clientAge >= 15 && userInput == false && clientTickets <= 3;

            Console.WriteLine("Were you qualified today?");
            Console.WriteLine(insApproval);
            Console.ReadLine();
        }
    }
}
