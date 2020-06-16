using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._132
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LineStrings =
           {"First Line" ,"Second Line","Third Line" ,"Fourth Line" ,"Fifth Line" };

            int[] TenInts = { 1, 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            List<string> MyList = new List<string>();
            MyList.Add("Red Lane");
            MyList.Add("Blue Lane");
            MyList.Add("Purple Lane");
            MyList.Add("Green Lane");
            MyList.Add("Indigo Lane");
            MyList.Add("Yellow Lane");
            MyList.Add("White Lane");

            int UserIndex = LineStrings.Length;

            while (!IsValidIndex(UserIndex, LineStrings.Length))
            {
                Console.WriteLine("Please give me an Index number from 0 to " + (LineStrings.Length - 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("Your Line is: " + LineStrings[UserIndex]);

            UserIndex = TenInts.Length;
            while (!IsValidIndex(UserIndex, TenInts.Length))
            {
                Console.WriteLine("Please give me an Index number from 0 to " + (TenInts.Length - 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("Your tenth number is: " + TenInts[UserIndex].ToString());

            UserIndex = MyList.Count;
            while (!IsValidIndex(UserIndex, MyList.Count))
            {
                Console.WriteLine("Please give me an Index number from 0 to " + (MyList.Count - 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("Your Lane is: " + MyList[UserIndex]);
            Console.ReadLine();
        }

        public static bool IsValidIndex(int Test, int Max)
        {
            return (Math.Abs(Test) < Max);
        }
    }
    }

