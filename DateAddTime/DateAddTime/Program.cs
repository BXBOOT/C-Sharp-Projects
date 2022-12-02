using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateAddTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//display crrent date and time(server time)
            Console.WriteLine(dateTime);
            Console.ReadLine();

            Console.WriteLine("Pick a number between 1 and 5");//user input o add hours
            int timeAdd = Convert.ToInt32(Console.ReadLine());//create variable for user input

            DateTime futureDate = dateTime.AddHours(timeAdd);//add 3 hours to the hours in date time

            Console.WriteLine("In hours it will be exactly: " + futureDate);// display new date time on console.
            Console.ReadLine();
        }
    }
}
