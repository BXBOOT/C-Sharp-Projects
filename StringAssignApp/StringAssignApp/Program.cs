using System;
using System.Text;


namespace StringAssignApp
{
    internal class Program
    {
        static void Main()
        {
            string MyName = "Mike";
            string FavMovie = "One Flew Over the Cuckoos Nest";
            string FavSnack = "is anything chocolate";

            Console.WriteLine("Hello, my name is " + MyName + ". My fvourite movie is " + FavMovie + ". My favourite quote frm the movie is \n \"Here's Johnny\".");
           

            MyName = MyName.ToUpper();
            Console.WriteLine(MyName);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My Name is Mike");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
