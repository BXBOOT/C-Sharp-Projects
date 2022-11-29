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



            if (!empl.Exists(e => (e.FirstName == "Joe")))
            {
                Console.WriteLine("Yes, Joe Exists");
            }
            Console.ReadLine();

            if (!empl.All(e => (e.Id > 005)))
            {
                Console.WriteLine("We have people with higher employee Id");
            }
            Console.ReadLine();
        }

    }
}
