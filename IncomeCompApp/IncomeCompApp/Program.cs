using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCompApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison.");
            int Num1, Num2;
            Console.WriteLine("Please enter the person 1 hourly rate");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the person 1 number of hours worked per week");
            Num2 = Convert.ToInt32(Console.ReadLine());
            int AnnualPay1;
            AnnualPay1 = (Num1 * Num2)*50;


            int Num3, Num4;
            Console.WriteLine("Please enter the person 2 hourly rate");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the person 2 number of hours worked per week");
            Num4 = Convert.ToInt32(Console.ReadLine());
            int AnnualPay2;
            AnnualPay2 = (Num3 * Num4) * 50; //50 working weeks in a year

            Console.WriteLine("Person 1 annual salary is " + AnnualPay1.ToString()); //uses calculation of num1 and num2 from firt person
            Console.ReadLine();
            Console.WriteLine("Person 2 annual salary is " + AnnualPay2.ToString()); //uses calculation of num3 and num 4 of second person
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than person 2");
            bool SalaryComp = AnnualPay1 > AnnualPay2;
            Console.WriteLine(SalaryComp.ToString()); //will print false unless the user inputs ake this a true statement
            Console.ReadLine();
        }
    }
}
