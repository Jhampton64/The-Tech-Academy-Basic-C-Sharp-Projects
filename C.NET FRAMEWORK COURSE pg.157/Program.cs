using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._157
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Math.Method(input);
            Console.WriteLine("Please input a decimal.");
            float input2 = float.Parse(Console.ReadLine());
            Math.Method(input2);
            Console.WriteLine("Please input an integer.");
            string input3 = Console.ReadLine();
            Math.Method(input3);
            Console.ReadLine();
        }

    }
}
