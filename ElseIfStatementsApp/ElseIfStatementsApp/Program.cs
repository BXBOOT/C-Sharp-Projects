using System;


namespace ElseIfStatementsApp
{
    internal class Program
    {
        static void Main()
        {
            string FirstName = "Mike";
            int AgeIs = 120;

            if (FirstName == "Mark" && AgeIs > 50)
            {
                Console.WriteLine("You are not who we are looking for");
            }
            else if (FirstName == "Mike" && AgeIs < 50)
            {
                Console.WriteLine("You are not old enough to be who we are loking for");
            }
            else if (FirstName == "Mike" && AgeIs > 50)
            {
                Console.WriteLine("Just the person we were looking for");
            }
            Console.ReadLine();
        }
    }
}
