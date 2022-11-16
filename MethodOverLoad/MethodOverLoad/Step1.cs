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

        public decimal Add(decimal a, decimal b)
        {
            return a / b;
        }

        public string Add(string a, string b)
        {
            return "" + "";
        }
    }
}

