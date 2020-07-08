using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._155
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number enter plus 10 = " + math.Classmath1(input)); 
            Console.WriteLine("Your number enter subtract 10 = " + math.Classmath2(input)); 
            Console.WriteLine("Your number enter times 10 = " + math.Classmath3(input));
            Console.ReadLine();


            Console.ReadLine();
        }

        
    }
}

    
