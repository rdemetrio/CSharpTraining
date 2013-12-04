using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int storeId = 0;
            string input = "[31] MAP - Installers Edge";

            string pattern = @"^\[[0-9]+\]";

            //Match matchDigits = Regex.Match(input, @"^\[\d+\]");
            
            Match m = Regex.Match(input, pattern);

            //storeId = int.Parse(matchDigits.Value);

            //Console.WriteLine(storeId);

            int StoreID;
            bool result = int.TryParse(m.Value, out StoreID);
            if (result == false)
            {
                Console.WriteLine("Not a number");
                Console.WriteLine(m.Value.ToString());

            }
            else
            {
                Console.WriteLine("StoreId: {0}", StoreID);
            }
        


            Console.ReadKey();
            
        }
    }
}
