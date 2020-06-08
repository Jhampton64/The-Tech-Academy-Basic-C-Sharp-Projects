using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine();
           
            Console.WriteLine("What page Number?");
            string page = Console.ReadLine();
            Console.WriteLine();
          
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string help = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exeperience = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine();

          
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
           
            Console.ReadLine();

           
        }
    }
}
