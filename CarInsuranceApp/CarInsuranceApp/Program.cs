using System;


namespace CarInsuranceApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Incredible Insurance");
            Console.WriteLine("How old are you?");
            int AgeIs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            bool DuiCharge = Convert.ToBoolean(Console.ReadLine());
            if (DuiCharge == true) //I do not know how to break out of the app and go straight to the not qualified part if this was true.
            {
                Console.WriteLine("You are disqualified from our insurance program. Good Luck Though");
            }
            else if (DuiCharge == false)
            {
                Console.WriteLine("One more question");
            }
            Console.WriteLine("How many speeding tickets do you have?");
            int SpeedTicket = Convert.ToInt32(Console.ReadLine());
           

            if (AgeIs > 15 && DuiCharge == false && SpeedTicket <= 3)
            {
                Console.WriteLine("You are Qualified for our insurance Package");
            }
            else
            {
                Console.WriteLine("We cannot offer you insurance at this time");
            }
            Console.ReadLine();
        }
    }
}
