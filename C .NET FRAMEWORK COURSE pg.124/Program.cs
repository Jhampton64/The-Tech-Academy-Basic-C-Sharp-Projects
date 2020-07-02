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
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            
            while (!isGuessed) 
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

           
            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again.");
                    break;
                case 29:
                    Console.WriteLine("You guessed 29. Try again.");
                    break;
                case 55:
                    Console.WriteLine("You guessed 55. Try again.");
                    break;
                case 12:
                    Console.WriteLine("You guessed the number 12. That is correct.");
                    break;
                default:
                    Console.WriteLine("You are wrong.");
                    break;
            }
            Console.ReadLine();


            


            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct.");
                        isGuessed = true;
                        break;
                    default: // If none of the cases are met default will run
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
           
            while (!isGuessed); 

            Console.Read();
        }
    }
}