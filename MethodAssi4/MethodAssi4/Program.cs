using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssi4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Divided divided = new Divided();//instantiate class

            Console.WriteLine("Select a number between 1 and 100");// get user input
            int userIn = Convert.ToInt32(Console.ReadLine());//create variable for user inoout
            divided.Half(userIn);//call method on user input
            Console.ReadLine();//show result

            decimal Num1 = AddingMethod(3.12356m, 3.12356m);//calling adding method
            double Num2 = AddingMethod(3.1, 3.1);//calling same method
            Console.WriteLine("AddingMethod is adding decimal numbers in number 1 and" +"\n"+ "doubles in number 2, same method, different parameters" +
                ":" + "\n" + Num1  + "\n" + Num2);
            Console.ReadLine();
        }

        static decimal AddingMethod(decimal num1, decimal num2)//static methods as part of the main. When they were under the Divided class
                                                               //they had to be public or would not be acessible by main
        {
            return num1 + num2;//decimal must have a return
        }

        static double AddingMethod(double num1, double num2)
        {
            return num1 - num2;//decimal must have a return
        }
    }
}
