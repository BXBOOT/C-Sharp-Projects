using System;


namespace WhileAndDoWhile
{
    internal class Program
    {
        static void Main()
        {
            //int MyNum = 0; // thi sets the variable to 0
            //while (MyNum < 10) // he loop will cotinue while this statment is true, the variable mynum is less than 10
            //{
            //    Console.WriteLine(MyNum); the console will show the numbers 0 through 9
            //    MyNum++; // incrementing my num by 1 until the number is 10
            //}
            //Console.ReadLine(); //prints output to the console

            int MyNum = 0; //set variable to 0. if the variable is higher than 10 this do while loop will just end
                do //perform this function while tis condition is true
            {
                Console.WriteLine(MyNum);
                MyNum++; //increment the variable mynum by 1 each time the loop is traversed
            }
            while (MyNum < 10); //while this condition is true increment my num variabe by 1 until it is n longer true.
            Console.ReadLine();// prints result to the console
        }
    }
}
