using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStudent
{
    public class Person 
    {
        public string FirstName { get; set; } //setproperty of the person class
        public string LastName { get; set; }//set property of the person class

        public void SayName()//give the person class a method with no parameters
        {
            {
                Console.WriteLine("Name: " + FirstName + " " + LastName);//required in method to print to console
            }
        }
    }


    public class  Employee : Person //inherit from the peson class to the emplyee class. employee can now be used for the program
    {
        public int Id { get; set; }
    }
}
