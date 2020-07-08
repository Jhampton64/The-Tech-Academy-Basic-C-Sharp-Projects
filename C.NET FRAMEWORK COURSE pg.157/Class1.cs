using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._157
{
    class Class1
    {
        public void Numbers2(int num1, int num2)
        {
            Console.WriteLine("Please input a Number.");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + int2);
            Console.WriteLine("The second number is:" + num2);
            Console.ReadLine();
            
        }

        
    }
}
