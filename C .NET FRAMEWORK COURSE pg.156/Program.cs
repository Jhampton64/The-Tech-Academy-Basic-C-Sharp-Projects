using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._156
{
    class Program
    {
        static void Number(int num1, int num2)
        {
            Console.WriteLine("Please enter a Whole Number.");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputNum + num1);

            Console.WriteLine("Please enter a Whole Number.");
            string inputNum2 = Convert.ToString(Console.ReadLine());
            if(inputNum2 == string.Empty)
            {
                Console.WriteLine("No number, No problem!");
                Console.ReadLine();

            }
            else
            {
                int x = Int32.Parse(inputNum2);
                Console.WriteLine(x + num2);
               
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Number(10, 5);
            
        }

    }
}

