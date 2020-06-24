using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            File.WriteAllText(@"fileio", number);
            Console.WriteLine("You selected " + number);
            Console.ReadLine();
            File.ReadAllText(@"fileio");
        }
    }
}
