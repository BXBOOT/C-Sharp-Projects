using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    internal class Employee
    {
        public string FirstName { get; set; }//property for FirstName 
        public string LastName { get; set; }//property for LastName
        public int Id { get; set; }//property for id

        public static bool operator== (Employee emp1 , Employee emp2 )//overide operator to check if equal
        {
            if (emp1.Id.Equals(emp2.Id))//compares the emp1 and emp 2 to be equal id or not in an if statement
            {
                return true;//should return true if they are equal
            }
            return false;//must return opposite if the return value of true is not met
        }

        public static bool operator !=(Employee emp1, Employee emp2)//overide operator to check if equal
        {
            if (!emp1.Id.Equals(emp2.Id))//! has to preceed the if statement or it throws an error
            {
                return true;//should eturn true if they are not equal
            }
            return false;
        }
    }
}
