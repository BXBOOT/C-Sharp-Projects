using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number myNum = new Number();//create an instance of the struct Number
            myNum.Amount = 5269875.2315478m;//assign a value to the value of AMOUNT assigned in the struct
            myNum.Anum(myNum.Amount);//call the method to print to console
            Console.ReadLine();
        }

        struct Number// name of the struct
        {
            public decimal Amount;//assign the value of the struct as a decimal data type, public so it is uded throughout the program.

            public void Anum(decimal a)// set a method to be called to use the struct in the main
            {
                Console.WriteLine("the amount is " + a);//when method called this goes to the console.
            }
        }
    }
}
