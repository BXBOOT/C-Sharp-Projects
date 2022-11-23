using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Employee employee = new Employee();//instnatiate the class employee which inherts from the abstract person class
                employee.FirstName = "Sample";//use get ad set for parameters
                employee.LastName = "Student";
                employee.SayName();//call the method
                employee.Quit();//the override of quit prints each different message to the console.
                Console.ReadLine();//print to console

               
                Employee boss = new Boss();//instantiate a different object which inherits get set from employee and interface
                boss.FirstName = "Bob";//use get add set for parameters
                boss.LastName = "Frapples";
                boss.SayName();//call the method
                boss.Quit();//the override of quit prints each different message to the console.
                Console.ReadLine();//print to console

                Employee recep = new Receptionist();//instantiate a different object which inherits get set from employee and interface
                recep.FirstName = "Susie";//use get add set for parameters
                recep.LastName = "Cue";
                recep.SayName();//call the method
                recep.Quit();//the override of quit prints each different message to the console.
                Console.ReadLine();//print to console

            }
        }

    }

}
