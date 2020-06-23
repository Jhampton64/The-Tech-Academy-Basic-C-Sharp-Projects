using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._221
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string Company = "Neo Kmart";
            var Year = 2025;
            Employee employeeA = new Employee(5023, "Mark Wayne");
            Employee employeeB = new Employee("Kenya Miller");
            Console.WriteLine("Welcome to " + Company + ". \nOpened in " + Year + ", two new people have joined our family today. \n" + employeeA.name + " & " + employeeB.name + "\nwe look forward to working with you! ");
            Console.ReadLine();
        }

    }
}
