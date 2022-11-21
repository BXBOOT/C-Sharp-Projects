using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();//instnatiate the class employee which inherts from the abstract person class
            employee.FirstName = "Sample";//use get ad set for parameters
            employee.LastName = "Student";
            employee.SayName();//call the method
            Console.ReadLine();//print to console
        }
    }
}
