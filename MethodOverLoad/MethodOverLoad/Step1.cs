using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoad
{
    public class Step1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(decimal a, decimal b)
        {
            return Convert.ToInt32(a / b);
        }

        public int Add(string a, string b)
        {
            try
            {
                return Convert.ToInt32(a + b);
            }
            catch
            {
                Console.WriteLine("the opertion did not complete. a number must be used");
                return -1;

            }
            
        }
    }
}

