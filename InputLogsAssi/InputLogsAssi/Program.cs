using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputLogsAssi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number no less than 10 no more than 50");//ask user inut
            int userin = Convert.ToInt32(Console.ReadLine());//makes variable userin available for temp data storageand return

            using (StreamWriter File = new StreamWriter(@"C:\etc\etc\Logs\log.txt", true))//change the path to where your text files are
            {
                File.WriteLine(userin);//write to the text file
            }

            string content = File.ReadAllText(@"C:\etc\etc\etc\Logs\log.txt");//change the path to where your text files are. Reds back from the text file
            Console.WriteLine(content);//displays content in console
            Console.ReadLine();
        }
    }
}
