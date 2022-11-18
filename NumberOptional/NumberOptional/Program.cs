using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NumberOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();//instantiat the class

            Console.WriteLine("please enter a number");//user input for a number
            int num1 = Convert.ToInt32(Console.ReadLine());//store number in type int
            Console.WriteLine("enter your second number, you can leave this blank by hitting enter");//user input for second number opion to leave nu 2 blank
            
            try//try catch block to use optional parameter set in method
            {
                int num2 = Convert.ToInt32(Console.ReadLine());//read num2 input here
                Console.WriteLine("your numbers have been added by a method, the answer is " + math.Maths(num1, num2));//show result if num1 and num2 are not empty
            }
            catch
            {
                Console.WriteLine("you chose to leave number 2 blank, you first number was " + num1);//catch the error if num 2 is left blank but still print first num to console.
            }

            Console.ReadLine();

        }
    }
}
