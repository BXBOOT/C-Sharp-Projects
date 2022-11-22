using System;
using System.Collections.Generic;
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
                employee.Quit();
                Console.ReadLine();//print to console

                
                Employee boss = new Boss();// create new object boss
                boss.FirstName = "Bob";
                boss.LastName = "Smith";
                boss.SayName();
                boss.Quit();

                Console.WriteLine("\n");

                Employee receptionist = new Receptionist();//Create a new object of receptionist inherits what employee inherts from person
                receptionist.FirstName = "Brenda";
                receptionist.LastName = "Smithers";
                receptionist.SayName();
                receptionist.Quit();
                Console.ReadLine();//Readsline on Console.
            }
        }
    }
}
