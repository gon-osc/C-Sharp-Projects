using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill183___CONSOLE_APP_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is nine minus 3 divided by one-third plus one?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool answerIs = number == 1;

            //do
            //{
            //    switch (number)
            //    {
            //        case 3:
            //            Console.WriteLine("You guessed 3. Try Again.");
            //            Console.WriteLine("Hint: PEMDAS.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 7:
            //            Console.WriteLine("You guessed 7. Try Again.");
            //            Console.WriteLine("Hint: PEMDAS.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 9:
            //            Console.WriteLine("You guessed 9. Try Again.");
            //            Console.WriteLine("Hint: PEMDAS.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 1:
            //            Console.WriteLine("That is correct!. After applying PEMDAS the correct answer is 1.");
            //            answerIs = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Try Again, Dont give up!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}
            //while (!answerIs);

            int myNumber = 10;
            while(myNumber <= 20)
            {
                Console.WriteLine(myNumber);
                myNumber++;   
            }

            Console.Read();

        }
    }
}
