using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instantiate the employee class. i inherits all the person class attributes
            employee.FirstName = "Sample"; //can enter whatevr name to here
            employee.LastName = "Student"; //can enter whatever name to here
            employee.SayName();//calls the method to prit to console

            Console.ReadLine();

        }
    }
}
