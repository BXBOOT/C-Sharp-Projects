using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    internal class Program
    {
        static void Main()
        {
            List<int> myNum = new List<int>() { 10, 22, 58, 94 };

            Console.WriteLine("Pease enter a number. This number will be divided by each number in the list");
            int UserNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myNum.Count; i++)
            {
                foreach (int item in myNum)
                    int newNum = myNum / UserNum
                Console.WriteLine(myNum[i]);
            }
            Console.ReadLine();
        }
        
    }
}
