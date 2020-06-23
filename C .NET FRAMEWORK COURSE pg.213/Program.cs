using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._213
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The Time is currently " + now);
            Console.WriteLine("Select a number to jump forward in time!");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime input = now.AddHours(hours);
            Console.WriteLine("It is now " + input + ".");
            Console.ReadLine();

        }
    }
}
