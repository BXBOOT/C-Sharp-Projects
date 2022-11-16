using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());

            Threes obj = new Threes();
            obj.Adder(x);
            
            Console.WriteLine("The answer is " + obj + value);
            Console.ReadLine();
            
        }
        
    }
}
