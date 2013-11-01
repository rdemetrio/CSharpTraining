using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManipulateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contains method
            string word = "get";

            Console.WriteLine("***CONTAINS METHOD***");
            Console.WriteLine("The search word is: '{0}'", word);
            TestContains(word);
            Console.WriteLine("***END CONTAINS***");
            Console.WriteLine();
            Console.WriteLine("***SUBSTRING METHOD***");
            TestSubstrings();
            Console.WriteLine("***END SUBSTRING***");
            Console.WriteLine();
            Console.WriteLine("***REPLACE METHOD***");
            TestReplaceStrings();
            Console.WriteLine();
            Console.WriteLine("***END REPLACE***");


           
            Console.ReadKey();
        }

        static void TestContains(string str)
        {
            string aStr = "'Coding the world one string at a time...'";
            bool contains = aStr.Contains(str);

            if (contains == true)
            {
                Console.WriteLine(contains + " it does contain the search word.");
                Console.WriteLine();
                Console.WriteLine("Original sentence: " + aStr);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Word does not exist.");
                Console.WriteLine("Original sentence: " + aStr);
            }
        }

        static void TestSubstrings()
        {
            string str = "Substring returns specific char index of string.";

            string revisedStr = str.Substring(0, 9);

            Console.WriteLine("Original sentence: '{0}'", str);
            Console.WriteLine();
            Console.WriteLine(revisedStr);
        }

        static void TestReplaceStrings()
        {
            string str = "Strings and more strings all over the place.";

            string rStr = str.Replace("place", "world");

            Console.WriteLine("Original sentence: '{0}'", str);
            Console.WriteLine();
            Console.WriteLine("Revised sentence: '{0}'", rStr);
        }

    }
}
