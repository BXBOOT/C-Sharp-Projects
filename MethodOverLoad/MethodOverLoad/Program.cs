using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Step1 step = new Step1();// create the object named step

            Console.WriteLine("The answer is, " + step.Add(5, 3));// return an int result

            Console.WriteLine("The answer is, " + step.Add("b", "22"));// conversion done in method with try/catch theat prints -1 and message

            Console.WriteLine("The answer when converting a decimal to int is, " + step.Add(27.5m, 7.5m));//answer will be whole number because of int conversion

            Console.ReadLine();
        }
    }
}
