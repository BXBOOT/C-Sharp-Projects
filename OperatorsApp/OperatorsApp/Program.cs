using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();//instantiate 1 employye
            emp1.FirstName = "Billy";//params as set out in class
            emp1.LastName = "Bob";//params as set out in class
            emp1.Id = 456;

            Employee emp2 = new Employee();//second employee instantiate
            emp2.FirstName = "Billy";//params as set out in class
            emp2.LastName = "Rob";//params as set out in class
            emp2.Id = 456;


            if (emp1 == emp2)//comparing the entirety of employee 1 to employee 2
            {
                Console.WriteLine("These two emplyees are twins");//make changes to see different output
            }
            else
            {
                Console.WriteLine("These 2 might look alike but they are not the same");
            }

            Console.ReadLine();
        }
    }
}
