using System;


namespace PackageQuote
{
    internal class Program
    {
        static void Main()
        {
            int Maxweight = 50;
            int MaxDimensons = 50; //Corrected calculation to area not volume
            Console.Write("Welcome to Package express. Press enter and follow the instructions below.");
            string Welcome = Console.ReadLine();
            Console.WriteLine("Please enter the weight of he package"); //if you insert a package weight over 50 the app skips the rest of the code and goes straight to Thank youexits
            int PackWeight = Convert.ToInt32(Console.ReadLine());
            if (PackWeight > Maxweight)
            {
                Console.WriteLine("Package is too heavy to ship with Package Express.");
                Console.ReadLine();
            }
            else if (PackWeight <= Maxweight)
            {
                Console.WriteLine("Please enter the width of the package");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Package Height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());
                int ActDimensions = width + height + length;
                int quoteCalc = width * height * length;
                int quote = (quoteCalc * PackWeight) / 100;
               if (ActDimensions > MaxDimensons) //I could probably use a teneray in here because it appears I ask the same question twice?
                {
                    Console.WriteLine("Package too big to ship with Package Express");
                    Console.ReadLine();
                }
                else if (ActDimensions <= MaxDimensons)
                {
                    Console.WriteLine("The estimated cost to ship your package is $" + quote);
                }

            }
            Console.WriteLine("Thank You!");
            Console.ReadLine();
        }
    }
}
