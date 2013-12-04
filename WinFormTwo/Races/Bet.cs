using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Races
{
    class Bet
    {
        int Amount;
        int Dog;
        Guys Bettor;


        public string GetDescription()
        {
            //TODO: Return a string that says who placed the bet
            //how much cash was bet and which dog he bet on 
            //("Name bets Amount on dog Dog#")
            //If the amount is zero, no bet was placed ("Name hasn't place a bet").
            return "";
        }

        public int PayOut(int Winner)
        {
            //TODO:  the parameter is the winner of the race. If the dog won,
            //return the amount bet. Otherwise, return the negative of the amount bet.

            return Amount;
        }
    }
}
