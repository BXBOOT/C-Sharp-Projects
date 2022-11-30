using System;
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
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee("Joe", "Morgan", 001));
            empl.Add(new Employee("Mike", "Pompei", 002));
            empl.Add(new Employee("Steve", "Stevens", 003));
            empl.Add(new Employee("Heather", "Charles", 004));
            empl.Add(new Employee("Stephanie", "Weisbird", 005));
            empl.Add(new Employee("Rebecca", "Nowel", 006));
            empl.Add(new Employee("Joe", "Adams", 007));
            empl.Add(new Employee("Jacob", "Treehill", 008));
            empl.Add(new Employee("Rudy", "Muggs", 009));
            empl.Add(new Employee("Bart", "Simpson", 010));

            List<Employee> employee1 = new List<Employee>();
            foreach (var i in empl)

            {
                if (i.FirstName == "Joe")
                {
                    empl.AddRange(employee1);
                    Console.WriteLine(employee1);
                }
                Console.ReadLine();
            }

            //list
            List<Employee> employees2 = new List<Employee>(); 
            employees2.Exists(e => (e.FirstName == "Joe"));
            Console.WriteLine(employees2);
            Console.ReadLine();


            ////list
            List<Employee> employee3 = new List<Employee>();
            employee3.All(e => (e.Id > 005));
            Console.WriteLine(employee3);
            Console.ReadLine();
        }

    }
}
