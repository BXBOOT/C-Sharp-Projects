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

        public static Employee operator== (Employee Id, Employee LastName)//overide operator to check if equal
        {
            return Id;
        }

        public static Employee operator!= (Employee Id, Employee LastName)//verride operator to check if not equal. done in pairs.
        {
            return Id;
        }
    }
}
