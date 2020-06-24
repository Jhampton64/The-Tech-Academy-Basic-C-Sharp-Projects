using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration Practice Program");

            string[] KHNames = {"Sora", "Donald", "Goofy", "Riku", "Kairi"  };

          
            Console.WriteLine("Please input Character name you wish to search for:");

            string appendText = Console.ReadLine();

            for (int i = 0; i < KHNames.Length; i++)
            {
                KHNames[i] = KHNames[i] + " " + appendText;
            }

            foreach (string name in KHNames)
            {
                Console.WriteLine(name);
            }

           
            Console.WriteLine("You may enter text to search for:");

            List<string> GUNnames = new List<string>
            {"Amuro", "Char", "Domon","Asia", "Setsuna", "Ribbons" };

            for (int j = 0; j <= (GUNnames.Count - 1); j++)
            {
                Console.WriteLine(GUNnames[j]);
            }

            Console.WriteLine("Enter the text you wish to search for:");
            string searchText = Console.ReadLine();
            int foundIndex = -1;

            for (int i = 0; i < GUNnames.Count; i++)
            {
                if (GUNnames[i].Contains(searchText))
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                Console.WriteLine("That text was not found.");
            }
            else
            {
                Console.WriteLine("Matching text: " + Convert.ToString(foundIndex));
            }

           
            Console.WriteLine("For the following names, you may enter text to search for.");
            List<string> REList = new List<string>
            {"Chris", "Jill","Leon","Clair", "Ada"};

            for (int j = 0; j < REList.Count; j++)
            {
                Console.WriteLine(REList[j]);
            }

            Console.WriteLine("Enter the text you wish to search for:");
            List<int> foundIndices = new List<int>();
            string searchString = Console.ReadLine();

            for (int i = 0; i < REList.Count; i++)
            {
                if (REList[i].Contains(searchString))
                {
                    foundIndices.Add(i);
                }
            }

            if (foundIndices.Count == 0)
            {
                Console.WriteLine("That text was not found.");
            }
            else
            {
                Console.WriteLine("Matching text: ");
                foreach (int index in foundIndices)
                {
                    Console.WriteLine(Convert.ToString(index));
                }
            }

            Console.WriteLine("Duplicates identified");



            List<string> duplicated = new List<string>();

            foreach (string item in REList)
            {
                if (!duplicated.Contains(item))
                {
                    duplicated.Add(item);
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

                     Console.ReadLine();
        }
    }
}