﻿using System;
using System.CodeDom;
using System.Collections.Generic;
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
            Console.WriteLine("The answer is, " + step.Add(958.2758m, 223.9m));//a decimal result
            Console.WriteLine("The answer is, " + step.Add(Convert.ToInt32("20"), Convert.ToInt32("22")));// a string result. written in the method and filled with empty "" at runtime
            Console.ReadLine();
        }
    }
}
