using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._156
{
    public class Optional_Parameters
    {
        public static int twoParameters(int first, int second = 0) 
        {
            int total = first + second;
            return total;
        }
    }
}
