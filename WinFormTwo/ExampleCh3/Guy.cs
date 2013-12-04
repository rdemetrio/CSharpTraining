using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleCh3
{
    class Guy
    {
        string Name;
        int Cash;

        public static int GiveCash(int cashGiven)
        {
            return cashGiven;
        }

        public static int ReceiveCash(int cashReceived)
        {
            return cashReceived;
        }
    }   
}
