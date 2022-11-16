using System;
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
            Step1 step = new Step1();
            Console.WriteLine("The answer is " + step.Add(5, 3));
            Console.WriteLine("The answer is " + step.Add(5, 3));
            Console.WriteLine("The answer is, " + step.Add("", ""));
            Console.ReadLine();
        }
    }
}
