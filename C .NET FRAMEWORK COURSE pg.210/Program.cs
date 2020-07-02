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
            File.WriteAllText(@"C:\Users\jhamp\Desktop\Git java\The-Tech-Academy-Basic-C-Sharp-Projects\C .NET FRAMEWORK COURSE pg.210\file1.txt", number);
            Console.WriteLine("You selected " + number);
            Console.ReadLine();
            File.ReadAllText(@"C:\Users\jhamp\Desktop\Git java\The-Tech-Academy-Basic-C-Sharp-Projects\C .NET FRAMEWORK COURSE pg.210\file1.txt");
        }
    }
}
