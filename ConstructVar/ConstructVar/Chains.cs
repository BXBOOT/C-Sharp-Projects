using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConstructVar
{
    class Chains
    {
        public Chains()//A costructor which has n arguments.
        {
            Console.WriteLine("Step-1");//This just prints to consol to show an output
        }

        public Chains(string a) : this()//A constructor with a parameter .
        {
            Console.WriteLine(a);//print to console to show second setep of chained constructors.
        }

        public Chains(string a, string b) : this("Step-2")//two args in the constructor
        {
            Console.WriteLine(a + b);
        }

    }
}
