using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>();
            things.Add("Pen");
        }
    }
}
