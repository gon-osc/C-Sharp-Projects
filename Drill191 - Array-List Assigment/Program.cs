using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill191___Array_List_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "Michael", "Wayne", "Luis", "Jeff", "John" };
            bool Keeplooping = true;
            while (Keeplooping == true)
            {
                Console.WriteLine("Choose an index to see who you will be partnered with.");

                try
                {
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your partner will be: " + Names[i]);
                    Keeplooping = false;
                }
                catch
                {
                    Console.WriteLine("Please select a valid index.");
                }
                }

            int[] number = new int[] { 2, 4, 6, 8, 10 };
            bool Keep = true;
            while (Keep == true)
            {
                Console.WriteLine("Please select an index to see what position you will be placed on our waiting list.");

                try
                {
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your waiting number will be: " + number[i]);
                    Keep = false;
                }
                catch
                {
                    Console.WriteLine("Please select a valid index.");
                }
            }


            List<string> colorList = new List<string>();
            colorList.Add("Blue");
            colorList.Add("Black");
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");

            Console.WriteLine("Select an index(0-4) to see what color team you will be placed on.");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Your team color will be: " + colorList[index]);



            Console.ReadLine();
        }
    }
}
