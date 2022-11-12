using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                List<int> myNum = new List<int>() { 10, 22, 58, 94 };//create a list of integers

                Console.WriteLine("Pease enter a number. This number will be divided by each number in the list");//asking for user input
                int userNum = Convert.ToInt32(Console.ReadLine());//saves the user input as a variable called userNum
                for (int i = 0; i < myNum.Count; i++)//start of the for loop which iterates through the length of the loop to divide mynum by usernum
                {
                    Console.WriteLine(myNum[i] / userNum);//prints the answer to the console
                }
                Console.WriteLine("The answers are in whole numbers because the variable int is used and rounds up");//explain numbers are whole numbers as ints are used.
                Console.ReadLine();
            }
            catch (FormatException ex)//catches error input using string instead of int
            {
                Console.WriteLine(ex.Message);//prints the standard system message on the console
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not use 0");//Prints error to console, cant use 0 as a number
            }
            catch (Exception ex)//catches all exceptions missed and prints system explanation to screen
            {
                Console.WriteLine(ex.Message);//If the exception is not caught by one we have stated, this message is a sysem message that will print
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("You made it all the way through, but did you get any errors? ");
            Console.ReadLine();
        }
    }
}
