using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What day is it today?");//user input for the day of the week
            string userin = Console.ReadLine();//save the user input in a string variable called userin

            WeekDay usrin;//set weekday and user input to be used n a try/catch block
            try
            {
                usrin = (WeekDay)Enum.Parse(typeof(WeekDay), userin);//user input converted by parse method of the string to int 32 value
                                                                     //checked against the value in the enum.
            }
            catch(Exception)//catches the exception if the nput is not contained in the enum list thingy
            {
                Console.WriteLine("select a actual day of the week");//returned if an improper or incorect statement is used
            }
            
            Console.ReadLine();

        }

        public enum WeekDay//establish the enum days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
