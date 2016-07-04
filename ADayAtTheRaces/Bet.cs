using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    class Bet
    {
        public int Amount;
        public Dog WhichDog;
        public Human Bettor;

        public string GetDescription()
        {
            return Bettor + " bets " + Amount + " on dog in lane " + WhichDog;
        }

        public int PayOut(Dog winner)
        {
            if(winner == WhichDog)
            {
                return Amount * 2;
            }
            else
            {
                return Amount * -2;
            }
            
        }
        
    }
}
