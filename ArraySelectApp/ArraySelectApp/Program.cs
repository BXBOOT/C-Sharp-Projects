using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ArraySelectApp
{
 class Program
    {
        static void Main()
        {
            string[] pets = { "Dogs", " cats", " birds", " mice", " gerbils", " ferrets" }; // create an instance of the pet array
            
            {
                //This first block is if you print the string array to the console and the user selcts directly from the array
                //it is not a random selection by the user.

                //Console.WriteLine("Which pet do you have?"); //ask for input from the user
                //Console.WriteLine(string.Join(",",pets)); //show the user their options from the string array
                //Console.ReadLine(); //show user their answer
                //string petType = Console.ReadLine(); //creates a string variable from user input

                //Console.WriteLine("Select a number between 0 and 5"); //ask for uer input
                //int petSelect = Convert.ToInt32(Console.ReadLine()); // creates a variable of int from user input called petSelect

                //if (petSelect == 0) //using if statements and else if statements to print to console the user selection from the string array
                //    Console.WriteLine("You have selected a dogs");
                //else if (petSelect == 1)
                //    Console.WriteLine("You have selected a cats");
                //else if (petSelect == 2)
                //    Console.WriteLine("You have selected a birds");
                //else if (petSelect == 3)
                //    Console.WriteLine("You have selected a mice");
                //else if (petSelect == 4)
                //    Console.WriteLine("You have selected a gerbils");
                //else if (petSelect == 5)
                //    Console.WriteLine("You have selected a ferrets");
                //else Console.WriteLine("You dont get a pet to take home because you didnt read the instructions");// this prints f the user selects a nuber outside the array or just hits enter and the app stops

                //Console.ReadLine(); //prints user selection from the array



                //int[] numArray = { 3, 1, 5}; //creates new array
                //Console.WriteLine("Select a number between 0 and 2"); //instructions for the user
                //int position = Convert.ToInt32(Console.ReadLine()); // create variable named position
                //if (position == 0)
                //    Console.WriteLine("Your position is 3"); //You can change these positons by changing the number in the array 
                //else if (position == 1)
                //    Console.WriteLine("Your position is 1");
                //else if (position == 2)
                //    Console.WriteLine("Your position is 5");

                //else
                //    Console.WriteLine("You dont listen very well so you dont get a turn. Goodbye"); //Satisfies the 3rd requirment to stop the app if a number outside the options is dselected.

                //Console.ReadLine(); //prints user selection

                List<string> bookList = new List<string>(); //create a list of strings (To creat a list of int change string to int)

                bookList.Add("Much Ado aboutC#"); //adds items to the list 
                bookList.Add("It Rains too Much In Vancouver");
                bookList.Add("Ice-Hockey is a summer sport, prove me wrong");
                bookList.Add("Why Ice-Hockey is not a summer sport");

                Console.WriteLine("pick a number 0 to 4"); //User instructions
                int bookSelect = Convert.ToInt32(Console.ReadLine()); //create a variable called bookSelect
                if (bookSelect == 0)
                    Console.WriteLine("You Chose to read " + bookList[0]); //selects the book titel from the list index
                else if (bookSelect == 1)
                    Console.WriteLine("You Chose to read " + bookList[1]);
                else if (bookSelect == 2)
                    Console.WriteLine("You Chose to read " + bookList[2]);
                else if (bookSelect == 3)
                    Console.WriteLine("You Chose to read " + bookList[3]);
                else Console.WriteLine("Why do you hate reading so much? Just pick a number");
                Console.ReadLine();//Shows the user selection
            }
        }
    }
}
