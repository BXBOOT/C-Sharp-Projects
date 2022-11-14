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

            string[] menu = new string[] { "Bacon", "Eggs", "Toast" };//set an array of strings
            foreach (string item in menu)
            {
                Console.WriteLine(item);//print array to console
            }
            Console.ReadLine();
            Console.WriteLine("Add a word that describes these menu items");//get user input
            string userword = Console.ReadLine();

            for (int i = 0; i < menu.Length; i++)//set parameter for for the for loop
            {
                Console.WriteLine(menu[i] + " " + userword); //re-write to console the menu, iterate through the for loop length and add the user input.
            }
            Console.ReadLine();//prints new list to the console.
            Console.WriteLine("\n");

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
            //There is probably a better way to write it!!!!!!

            List<string> moreThanOne = new List<string> { "A", "B", "C", "D", "E", "F", "C" };//set up a string list
            foreach (string letter in moreThanOne)//set a string variable to print the list to console
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("Type any duplicates you see here");// get user input

            foreach (string letter in moreThanOne)
            {
                int count = 0;//create a counter where count is 0
                int index = 0;//set index starting point at zero 
                foreach (string item in moreThanOne)
                {
                    if (letter == item)//if user input is contaned in the original string results in true start the loop
                    {
                        count++;
                        if (count > 1)//if the count is larger than the 1 item print to console with the index
                            Console.WriteLine($"Index pos of repeated element {letter} at index " + index); //prints the index position of the duplicate letters when entered  
                    }
                    index++;//increment through the index adding 1 each time                   
                }
                Console.ReadLine();
                Console.WriteLine("\n");
            }
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




