using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter an integer to see the results of a few math operations performed on it.");

            int inputNum = Convert.ToInt32(Console.ReadLine());
            int outputNum = mathOps.addFive(inputNum);
            Console.WriteLine(inputNum + " plus 5 equals " + outputNum);
            outputNum = mathOps.subtractThree(inputNum);
            Console.WriteLine(inputNum + " minus 3 equals " + outputNum);
            outputNum = mathOps.timesEight(inputNum);
            Console.WriteLine(inputNum + " times 8 equals " + outputNum);
            outputNum = mathOps.moduloTwo(inputNum);
            Console.WriteLine("The remainder of " + inputNum + " divided by 2 is " + outputNum);

            Console.ReadLine();

        }
    }
}
