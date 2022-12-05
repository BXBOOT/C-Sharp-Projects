using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructVar
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            const string codeCamp101 = "at Code Camp 101 in where we etc etc...";//once compiled cannot change the constant. Saves havig to re-write this
                                                                                //sentence repeatedly
            Console.WriteLine(codeCamp101);//prints the const to console
            Console.ReadLine();

            for (var x = 5; x < 10; x++)//the variable will be determined as int by c#
            {
                Console.WriteLine(x);//Console will write until number reaches 10
                Console.ReadLine();
            }

            Chains newChain1 = new Chains();//prints step 1, no args
            Console.WriteLine();

            Chains newChain2 = new Chains("Step-2");//prints 1 and 2 inherited 1 from no args, step 2 with 1 arg
            Console.WriteLine();

            Chains newChain3 = new Chains("Step-3", "Step-4");//prints all 4 chains inherited from first args steps and has 2 args  step 1 chained to step 2 to 3 and 4
            Console.WriteLine();
            Console.ReadLine();
        } 
        
    }
}
