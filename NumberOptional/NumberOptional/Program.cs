﻿using System;
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
            Class1 math = new Class1();

            Console.WriteLine("please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number, you can leave this blank by hitting enter");
            
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your numbers have been added by a method, the answer is " + math.Maths(num1, num2));
            }
            catch
            {
                Console.WriteLine("you chose to leave number 2 blank, you first number was " + num1);
            }

            Console.ReadLine();

        }
    }
}
