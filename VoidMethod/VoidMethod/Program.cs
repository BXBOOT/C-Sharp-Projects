using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voided voided = new Voided(); //instantiates the class
            voided.Half(10, 15);//2 int entered, first one has mathmatical operation secnd one printed to screen
            Console.ReadLine();

            voided.Half(size: 8, height: 54);//method called by name, use : colon and enter numbers. first int has math second gets printed as is
            Console.ReadLine();

        }
    }
}
