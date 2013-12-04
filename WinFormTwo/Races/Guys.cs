using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    class Guys
    {
        string Name;
        Bet myBet;
        int Cash;

        RadioButton myRadioButton;
        Label myLabel;

        public void UpdateLabels()
        {
            //TODO: Set my label to my bet's description and the label on my
            //radio button to show my cash ("Name has $$ bucks")
            
        }

        public void ClearBet()
        {
            //TODO: Reset bet field 
        }

        public bool PlaceBet()
        {
            //TODO: Place a new bet and store it in my bet field
            //TODO: Return true if the guy had enough money to bet

            return true;
        }

        public void Collect()
        {
            //TODO: Ask my bet to pay out
        }
    }
}
