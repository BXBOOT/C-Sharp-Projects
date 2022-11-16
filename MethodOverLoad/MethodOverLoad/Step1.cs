using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public double Add(double a, double b)
        {
            return a / b;
        }

        public string Add(string a, string b)
        {
            return "Is this " + " going to work?";
        }
    }
}
