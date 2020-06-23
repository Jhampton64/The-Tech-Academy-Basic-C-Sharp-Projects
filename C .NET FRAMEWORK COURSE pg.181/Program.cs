using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._181
{
    public class Program
    {
        public static void Main()
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Harry");
            employee.Things.Add("James");
            employee.Things.Add("Heather");
            Employee<int> ID = new Employee<int>();
            ID.Things = new List<int>();
            ID.Things.Add(1);
            ID.Things.Add(2);
            ID.Things.Add(3);
            foreach (string x in employee.Things)
            {
                Console.WriteLine(x);
            }
            foreach (int y in ID.Things)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
