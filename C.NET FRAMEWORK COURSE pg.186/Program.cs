using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._186
{
   
    class Program
    {
        public enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private static void Main()
        {
            try
            {
                Console.WriteLine("What day is it?");
                string day = Console.ReadLine();
                DayOfTheWeek dayOfTheWeek = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), day);
                Console.WriteLine("Okay");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Response");
                Console.ReadLine();
            }


        }
    }
}
