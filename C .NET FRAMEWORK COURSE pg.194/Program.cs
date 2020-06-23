using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._194
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Kingstone", ID = 1 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Williams", ID = 2 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Micalo", ID = 3 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Peterson", ID = 4 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Susan", ID = 5 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Grayhorn", ID = 6 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Jefferson", ID = 7 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Prowler", ID = 8 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Lee", ID = 9 });
            employeesList.Add(new Employee()
            { FirstName = "Bob", LastName = "Smith", ID = 10 });



            foreach (var Employee in employeesList)
            {
                List<Employee> joeList = new List<Employee>();
                if (Employee.FirstName == "Joe")
                {
                    joeList.Add(Employee);
                }
            }

            List<Employee> joes = employeesList.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> ids = employeesList.Where(x => x.ID > 5).ToList();
            
        }


        

    }
}
