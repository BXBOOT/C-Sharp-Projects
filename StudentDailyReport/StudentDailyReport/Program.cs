using System;
using System.Runtime.InteropServices;

namespace StudentDailyReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("AOLCC Daily Report");
            Console.WriteLine("What is your name?");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Hello, " + StudentName + " what course are you registered in ");
            string RegCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int PageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything speific? PLEASE ANSWER \"TRUE OR FALSE\"");
            bool Answer1 = Convert.ToBoolean(Console.ReadLine());
            if (Answer1 == true)
            {
                Console.WriteLine("A teacher will be in touch shortly");
            }
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics");
            string FeedBack = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Pease be specific");
            string Suggestons = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int HourStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for participating in the Daily Report. An instructor will respond Shortly. Have a great day!");
            string Thanks = Console.ReadLine();
        }
    }
}
