using System;


namespace WhileAndDoWhile
{
    internal class Program
    {
        static void Main()
        {
            //int MyNum = 0;
            //while (MyNum < 10)
            //{
            //    Console.WriteLine(MyNum);
            //    MyNum++;
            //}
            //Console.ReadLine();

            int MyNum = 0;
                do
            {
                Console.WriteLine(MyNum);
                MyNum++;
            }
            while (MyNum < 10);
            Console.ReadLine();
        }
    }
}
