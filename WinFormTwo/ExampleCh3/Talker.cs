using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleCh3
{
    class Talker
    {
        public static int TestStringParameters(string sentence, int numberOfTimes)
        {
            string finalString = "";
            for (int i = 1; i <= numberOfTimes; i++)
			{
			    finalString += sentence + "\n";
			}

            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
