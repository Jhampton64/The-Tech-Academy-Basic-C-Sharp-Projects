using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._127
{
    class Program
    {
        static void Main(string[] args)
        {
            string istest = "there is a test";
            string dateString = DateTime.Today.ToShortDateString();
            
            string str = "Hello, " + istest + " starting at, " + dateString + ".";
            string upname = str.ToUpper();
            Console.WriteLine(upname);

            str += " Are you ready? ";
            Console.WriteLine(str);
            
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.AppendLine("Did you know, that paragraphs have at least five sentences.");
            sb.Append("Having to write one is really hard. ");
            sb.AppendLine("Especially if you have to make one up on the fly.");
            sb.AppendLine("I having trouble even writing this line."); 
            sb.AppendLine("I guess I'll stop now.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
