using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphAssi
{
    abstract class Person
    {
        public string FirstName { get; set; }//parameter set for abstract class
        public string LastName { get; set; }

        public abstract void SayName();//abstract method does not have a body
    }

    class Employee : Person, IQuittable //new class employee inherits from abstract person class. Interface allows for more optins than just 1 inheritance
    {
        public void Quit()
        {
            Console.WriteLine("Win the Lottery with these numbers 1, 2, 3, 4, 5 and quit your job");
        }

        public override void SayName()// the override method from the abstract class so it can be called by the employee class
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);//what the method should do when called in main program
        }
    }
}
