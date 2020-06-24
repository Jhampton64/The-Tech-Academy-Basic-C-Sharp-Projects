using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._225
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age;

            try
            {
                Console.WriteLine("Please tell me your current age.");
                if (!uint.TryParse(Console.ReadLine(), out age)) throw new ArgumentOutOfRangeException();

                Console.WriteLine("So you where born in {0}",
                    DateTime.Now.Date.AddYears((int)(-1 * age)).Year);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("zero or negative numbers not allowed!");
            }
            catch (Exception)
            {
                Console.WriteLine("Can't process that information.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
