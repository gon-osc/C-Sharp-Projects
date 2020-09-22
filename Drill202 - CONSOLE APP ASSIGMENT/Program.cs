using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill202___CONSOLE_APP_ASSIGMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE APP ASSIGNMENT PART ONE:

            //Console.WriteLine("Please type in your name to see what we people think about you.");
            //string userInput = Console.ReadLine();
            //string[] phrases = { "You are awesome ", "You are smart ", "You are funny ", "You are hardworking " };

            //foreach (string p in phrases)
            //{
            //    Console.WriteLine(p + userInput);
            //}
            //foreach (string p in phrases)
            //{
            //    Console.WriteLine(p);
            //}

            //Console.ReadLine();

            //CONSOLE APP ASSIGNMENT PART TWO:

            //int nmbr = 0;

            //while (nmbr < 10)
            //{

            //    Console.WriteLine("i = " + nmbr);
            //    nmbr++;
            //}

            //Console.ReadLine();

            //CONSOLE APP ASSIGNMENT PART THREE:

            //List<int> waterTemp = new List<int>()
            //{
            //    88,
            //    79,
            //    81,
            //    72,
            //    60,
            //    85,
            //};

            //foreach (int temp in waterTemp)
            //{
            //    if (temp < 80)
            //    {
            //        Console.WriteLine("!!ALERT!! Please bring these TEMP back up: " + temp);
            //    }
            //}

            //Console.ReadLine();


            //List<int> heaterTemp = new List<int>()
            //{
            //    88,
            //    79,
            //    80,
            //    72,
            //    60,
            //    85,
            //};

            //foreach (int temp in heaterTemp)
            //{
            //    if (temp <= 80)
            //    {
            //        Console.WriteLine("!!ALERT!! Please bring these TEMP back up: " + temp);
            //    }
            //}

            //Console.ReadLine();

            //CONSOLE APP ASSIGNMENT PART FOUR:

            //List<string> firstStates = new List<string>()
            //{
            //    "delaware",
            //    "pennsylvania",
            //    "new jersey",
            //    "georgia",
            //    "connecticut",
            //    "massachusetts",
            //    "maryland",
            //    "south carolina",
            //    "new hampshire",
            //    "virginia",
            //    "new york",
            //    "north carolina",
            //    "rhode island",
            //};


            //Console.WriteLine("Type in a name of a state to see if it was part of the original 13 colonies.");
            //string userState = Console.ReadLine();

            //int index = firstStates.FindIndex(a => a.Contains(userState));

            //if (firstStates.Contains(userState) == true)
            //{
            //    Console.WriteLine("Correct that state was part of the original 13 colonies.");
            //    Console.WriteLine("That state is number " + index + " of our list of states.");
            //}
            //else
            //{
            //    Console.WriteLine("Item does not exist!");
            //}

            //Console.ReadLine();

            //CONSOLE APP ASSIGNMENT PART FIVE:

            //List<string> popNames = new List<string>()
            //{
            //    "Joe",
            //    "Matt",
            //    "Wayne",
            //    "Micah",
            //    "John",
            //    "Albert",
            //    "Matt",
            //    "Chris",
            //};

            //Console.WriteLine("Find out the index placement of each name");

            //foreach (string n in popNames)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.ReadLine();


            //Console.WriteLine("Please input the name: ");
            //string userName = Console.ReadLine();
            //var duplicateIndexes = popNames
            //.Select((t, i) => new { Index = i, Text = t })
            //.Where(p => p.Text == userName)
            //.Select(p => p.Index);


            //foreach (var i in duplicateIndexes)
            //{
            //    Console.WriteLine(userName + " is found at index {0}", i);
            //}
            //if (popNames.Contains(userName) == true)
            //{
            //}
            //else
            //{
            //    Console.WriteLine("Item does not exist!");
            //}

            //Console.ReadLine();

            //CONSOLE APP ASSIGNMENT PART SIX:

            List<string> popGames = new List<string>()
            {
                "Monopoly",
                "Clue",
                "LIFE",
                "Connect Four",
                "Operation",
                "Jenga",
                "LIFE",
                "SORRY",
            };

            var dupGames = popGames.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            foreach (var duplicate in dupGames)
            {
                Console.WriteLine("It seems " + duplicate + " appears more than once in this list");
            }

            Console.ReadLine();
        }
    }
}
