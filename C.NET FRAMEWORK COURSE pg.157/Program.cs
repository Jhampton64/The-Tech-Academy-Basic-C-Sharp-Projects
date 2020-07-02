using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._157
{
    class Program
    {
        static void Numbers2(int num1, int num2)
        {
            Console.WriteLine("Please enter a Whole Number.");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+ int2);
            Console.WriteLine(num2);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Numbers2(num1:10,num2:20);
        }

        private static void Numbers2(int num1)
        {
            throw new NotImplementedException();
        }
    }
}