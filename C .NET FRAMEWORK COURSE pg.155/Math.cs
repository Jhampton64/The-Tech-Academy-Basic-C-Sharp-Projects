using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._155
{
    static class Method
    {
        public static void Divide(int parameter)
        {

            int answer = parameter / 2;
            Method.Divide(parameter, answer);

        }
        public static void Divide(int parameter, int answer)
        {
            Console.WriteLine(parameter + " divided by 2 = " + answer);
            Console.ReadLine();

        }

    }
}  
