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
            Console.WriteLine("Menu starting items"); //prints to console the original menu
            foreach (string value in menu1)//iterates through the array
            {
                Console.WriteLine(value);//prints to console
            }

            List<string> ItemList = new List<string>(); //empty list string
            //Ths satisfies the Console App assignment part 3 showing that while the empty lst is less than 3 items, add another item.
            for (int i = 0; i < 3; i++) // Continue For Loop until i is < the needed amount. will loop 3 time with condition set at < 3.
            {
                Console.WriteLine($"{i + 1}: Add 3 more items to the menu"); // Asks for user input into array.
                string ListInput = Console.ReadLine(); // User inputs value into field.
                ItemList.Add(ListInput); //adds the user input string to the item list
            }

            //Console App part 2 of 6
            //This is an infnite loop of continuously printing system info.... 
            //there is no break point. the original thought was that while menu was printed, it would just add the items to the list
            //and then addRange the user input after the original list printed.
            //while (true)
            //{
            //    Console.WriteLine(menu1);
            //}
            //Console.ReadLine();

            Console.WriteLine("Full menu with added items");//prints to conaole with the new added items from user input
            menu1.AddRange(ItemList);//takes menu1 list and adds the variable itemlist to the end of the list
            foreach (string value in menu1) //loop through the string list menu 1 to add the to the list
            {
                Console.WriteLine(value);//Priints to console the new value of the amended menu list
            }
            Console.ReadLine();

            //Console App part 4 of 6

            List<string> OneofKind = new List<string>() { "The", "quick", "brown", "fox", "is", "dizzy" }; // a string list of unique words

            Console.WriteLine("Select a letter of the alphabet and see if it exists in the hidden sentence"); // getting user input
            string Letter = Console.ReadLine();//store user inut in variable string named Letter

            int index = OneofKind.FindIndex(p => p.Contains(Letter)); //iterate through the list to find user input first appearance
            Console.WriteLine("That letter exists in the sentence at index: " + index); //display index on console
            foreach (string value in OneofKind)
            {
                Console.WriteLine(value);//Writes the sentence afterthe user input
            }
            Console.ReadLine();


            //Console App part 5 of 6
            //This code is very easily broken by changing one small element to show a false positive.
            //There is probably a better way to write it!!!!!!

            List<string> moreThanOne = new List<string> {  "A", "B", "C", "D", "E", "F", "C" };//create the string list

            foreach (string value in moreThanOne)
            {
                Console.WriteLine(value);
            }

            for (int i = 0; i < moreThanOne.Count()-1; i++)//for loop setting parameters to iterate through the list

                if (moreThanOne.Count != moreThanOne.Distinct().Count())//if statement to determine if the list is distinct
                {
                    Console.WriteLine("There are duplicates in this list");//prints if it finds a duplicate
                }
                else
                {
                    Console.WriteLine("no duplicates exist in this list");//prints if finds no duplicate. I do not kow why these statements print 5 times
                }
            Console.ReadLine();

            //ConsoleApp part 6 of 6

            List<string> finalPart = new List<string> { "A", "B", "C", "D", "E", "F", "C" };//create the list
            
                foreach (string value in finalPart)//foreach loop to print the vaue of the list on the console.
            {
                if (finalPart.IndexOf(value) != finalPart.LastIndexOf(value))//This compares the index of each item and if it appears more tha once it shows as a duplicte.
                    Console.WriteLine(value + " -this item is a duplicate");//prints only the duplicated value.
                else
                {
                    Console.WriteLine(value + "-This is not a duplicate");//Prints as many times as the loop iterates throough the lst f there are no duplicates.
                }
            }
            Console.ReadLine();
        }
    }
}




