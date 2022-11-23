using System;
using System.Collections.Generic;
using System.Data;
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
        public override void SayName()// the override method from the abstract class so it can be called by the employee class
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);//what the method should do when called in main program
        }

        public virtual void Quit()//the interface must be marked virtual so the inheriting class can use the override to produce a different
                                  //console print out. virtual void only has to be done once, following objects will inherit the rules
        {
            Console.WriteLine("can only quit when you have learnt it all");
        }

 
    }
    class Boss : Employee
    {
        public override void Quit()//this override of the quit method 'inherited' from employee will have a different rint to console.
        {
            Console.WriteLine("Boss is not allowed to quit");
            
        }
    }

    class Receptionist : Employee
    {
        public override void Quit()//this override of the quit method 'inherited' from employee will have a different rint to console.
        {
            Console.WriteLine("Susie can retire but she never quits");
            //base.SayName(); if this remains in, it will print the inherited console.writeline from person
        }

    }

}
