using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    abstract class Person
    {
        public string FirstName { get; set; }//parameter set for abstract class
        public string LastName { get; set; }

        public abstract void SayName();//abstract method does not have a body
    }     

        class Employee : Person//new class employee inherits from abstract person class
        {
            public override void SayName()// the override method from the abstract class so it can be called by the employee class
            {
                Console.WriteLine("Name : " + FirstName + " " + LastName);//what the method should do when called in main program
            }
        }
    
}
