using System;


namespace TechAcademyDR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your Name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
            
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("I see that you are on our " + courseName + " course");

            
            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So you are on page " + pageNumber + " of our " + courseName + " course");

            Console.WriteLine("Do you need help  with anything? Please answer 'true' or 'false'");
            string userInput = Console.ReadLine();
            if (userInput == "true")
            {
                Console.WriteLine("Thank you for reaching out to us for help.");
            }
            else
            {
                Console.WriteLine("Dont hesitate to reach out to us for any help.");
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string userExperience = Console.ReadLine();
            

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string userFeedback = Console.ReadLine();
            


            Console.WriteLine("How many hours did you study today?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for putting in " + hoursWorked + " hours of study today");
            
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
            
            
            
        }
    }
}
