using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to count to 100.");
            int low = Convert.ToInt32(Console.ReadLine());
            bool islow = low == 1;
            do
            {
                Console.WriteLine(low);
                low++;

            }
            while (low < 101);

            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            bool iscorrect = number == 52;
            do
            {
                switch (number)
                {
                    case 22:
                        Console.WriteLine("you guessed 22, Retry");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 42:
                        Console.WriteLine("you guessed 42, Retry");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 52:
                        Console.WriteLine("you guessed 52, Correct!");
                        iscorrect = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }


            }

            while (!iscorrect);


            Console.ReadLine();
        }
    }
}