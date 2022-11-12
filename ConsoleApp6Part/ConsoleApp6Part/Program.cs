using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ConsoleApp6Part
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App part 1 of 6

            List<string> menu1 = new List<string>() { "bacon", "eggs", "toast" }; //creates a list string
            foreach (string food in menu1) //foreach loop to print the list for user to see
            {
                Console.WriteLine(food);//new created string food prints to the cnsole
            }
            List<string> adjective = new List<string>(); //create new string for the user input to be added

                Console.WriteLine("\n");//new line for a bit of space between to make it easier to read.
            {
                Console.WriteLine("Add a one word description of these items");//asking for user input which is added to the new string
                string descrip = Console.ReadLine();
                Console.WriteLine("\n");//spacer
                adjective.Add(descrip);//add the user input to the new list string
            }

            menu1.InsertRange(1, adjective);//*****************************************************************************//
            menu1.InsertRange(3, adjective);//this adds the user input to the end of each index. not pretty but it works **
            menu1.InsertRange(5, adjective);//*****************************************************************************//

            foreach (string added in menu1)//another foreach loop to print the added description of the items.
            {
                Console.WriteLine(added);
            }
            Console.ReadLine();//we can now see the result of tsaty aafter each original item.

            //Console App part 2 of 6

            //An infinte loop on purpose would exist in a game for example
            int movement = 0;//sets the motion to 0 starting point
            Console.WriteLine("This is an example of an infinte loop if you remove the break operator. This stops at 10. \n if you remove break it will continue forever");
            while (true)//the start of a while loop
            {
                if (movement == 10)//*********************************************
                {                  //if you remove this break point perator the **
                                   //counter will just keep running to infinity **
                    break;         //*******************************************//
                }
                Console.WriteLine(movement);
                movement++; //increment the movement variable by 1 each time it iterates through the while loop.
                
            }
            Console.WriteLine("\n");

            //Console App part 3 of 6

            for (int i = 0; i < 5; i++)//creates parameters for the for loop where operator is less than
            {
                Console.WriteLine(i);//i will print as long as i is less than(<) the number 5 in the for loop.
            }                       //If you chnge the value of 5 i will print to that and inrement by 1 each time it loops
            Console.ReadLine();// prints line to the console.
            Console.WriteLine("\n");

            int j = 0; //Set the value of i
            do //start of the do loop, do this.....
            {
                Console.WriteLine(j);//do this print i to console
                j++;//increment by 1 each loop
            }
            while (j <= 5);//do this while i is less than < or = to 5
            Console.ReadLine();
            Console.WriteLine("\n");

            //Console App part 4 of 6

            List<string> oneOfaKind = new List<string> { "Mike", "Ben", "Serena", "Dave", "Eggbert", "Frank", "Chris" };//create the string list
            foreach (string value in oneOfaKind)
            {
                Console.WriteLine(value);//prints list to console so user can select name
            }
            Console.WriteLine("enter your name to see where you are on the list.");
            string userinp = Console.ReadLine(); //creates a string variable stored as userin

            if (!oneOfaKind.Contains(userinp))//determines if user input is not on the list
            {
                Console.WriteLine("You are not on the list");//if user inut it not on the list
            }
            else//using else to netst a while loop for whe user input is true
            {

                while (true)
                {
                    int position = oneOfaKind.FindIndex(p => p.Contains(userinp)); //finds the index of the user input
                    Console.WriteLine("You are  " + position + "  in line for the roller coaster"); //prints user input to console with position of their name
                    break;//if we do not use break in the while Loop this will be an infinite loop printing he same above line over and over again
                }
            }
            Console.ReadLine();
            Console.WriteLine("\n");

            //Console App part 5 of 6
            //This code is very easily broken by changing one small element to show a false positive.
            //There is probably a better way to write it!!!!!!

            List<string> moreThanOne = new List<string> {  "A", "B", "C", "D", "E", "F", "C" };//create the string list
            foreach (string value in moreThanOne)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Can you spot any duplicates in this list of letters? Enter the duplicate if you see it.");
            string userin = Console.ReadLine();
            string upuserin = userin.ToUpper();//converts user input to upper case letters
                if (moreThanOne.Count != moreThanOne.Distinct().Count())//if statement to determine if the list is distinct
                {
                int position = moreThanOne.FindIndex(p => p.Contains(upuserin));
                Console.WriteLine("There are duplicates in this list: " + position);//prints if it finds a duplicate and shows the first appearance of the duplicate
                }
                else
                {
                    Console.WriteLine("no duplicates exist in this list");//prints if finds no duplicate. I do not kow why these statements print 5 times
                }
            Console.WriteLine("\n");

            //ConsoleApp part 6 of 6

            List<string> finalPart = new List<string> { "A", "B", "C", "D", "E", "F", "C" };//create the list
            
                foreach (string value in finalPart)//foreach loop to print the vaue of the list on the console.
            {
                if (finalPart.IndexOf(value) != finalPart.LastIndexOf(value))//This compares the index of each item and if it appears more tha once it shows as a duplicte.
                    Console.WriteLine(value + "-this item is a duplicate");//prints only the duplicated value.
                else
                {
                    Console.WriteLine(value + "-This is not a duplicate");//Prints as many times as the loop iterates throough the lst f there are no duplicates.
                }
            }
            Console.ReadLine();
        }
    }
}




