using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._191
{
    public class Program
    {
        public static void Main()
        {
            Number number = new Number();
            number.Amount = 6.7m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
