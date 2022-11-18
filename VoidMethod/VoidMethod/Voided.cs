using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Voided
    {

        public void Half(int size, int height)//public void class does not require a return arg
        {
            int less = size / 2;//use a variable named less to store the result of the math and send to console.
            Console.WriteLine("your shoe size divided by 2 = {0} , is proportional to your height = {1}" , less, height);//this divides the first parameter by 2 but just prints the second
        }
    }
}
