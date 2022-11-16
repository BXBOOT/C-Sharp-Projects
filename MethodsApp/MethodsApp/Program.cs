using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());

            Called call = new Called();

            Console.WriteLine("The answer is " + call.Add(2, value));
            Console.WriteLine("The answer is " + call.Subtract(2, value));
            Console.WriteLine("The answer is " + call.Division(2, value));
            Console.ReadLine();
        }
    }
}
