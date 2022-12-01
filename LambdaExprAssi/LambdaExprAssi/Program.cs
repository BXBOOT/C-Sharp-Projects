using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExprAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>(); //Instnatiate the employee object as empl
            empl.Add(new Employee("Joe", "Morgan", 001)); //add 10 employee to list
            empl.Add(new Employee("Mike", "Pompei", 002));
            empl.Add(new Employee("Steve", "Stevens", 003));
            empl.Add(new Employee("Heather", "Charles", 004));
            empl.Add(new Employee("Stephanie", "Weisbird", 005));
            empl.Add(new Employee("Rebecca", "Nowel", 006));
            empl.Add(new Employee("Joe", "Adams", 007));
            empl.Add(new Employee("Jacob", "Treehill", 008));
            empl.Add(new Employee("Rudy", "Muggs", 009));
            empl.Add(new Employee("Bart", "Simpson", 010));

            
            foreach (var i in empl)//foreach loop looking for var named i in empl object
             
            {
                if (i.FirstName == "Joe")//nested if statement to find var i with FirstName Joe in empl
                {
                    Console.WriteLine(i.FirstName + " " + i.LastName);//print first and last name
                    Console.ReadLine();
                }
                
            }


            var result = empl.Where(e => e.FirstName == "Joe");//variable named result to collect list of conditions in lambda function
            foreach (var val in result) //calls the variable list to write to console
            {
                Console.WriteLine("all named : {0} ", val.FirstName + " "+  val.LastName + " "+  val.Id);  //prints the info to the cnsole
            }
            Console.ReadLine();


            var empl3 = empl.Where(e => e.Id > 005);//variable named empl3 to tem store data
            foreach (var v in empl3)
            {
                Console.WriteLine("all Id num above 5 : {0} ", v.FirstName + " " + v.LastName + " " + v.Id);//prints data to console
            }
            Console.ReadLine();

        }

    }
}
