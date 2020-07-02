using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._155
{
    class Operation
    {
        static void OP(int num1, decimal dec2, string str3)
        {
            Console.WriteLine("Please enter a Whole Number to add to 12.");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputNum+num1);
            Console.WriteLine("Please enter another Whole Number to add to 17.4.");
            decimal inputdec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputdec+dec2);
            Console.WriteLine("Now let me guess your aura color.");
            string inputstr = Convert.ToString(Console.ReadLine());
            Console.WriteLine(inputstr +"?"+  " I would have guessed " + str3+".");


            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            OP(12,17.4m,"Orange");
           
        }
    }
}

    
