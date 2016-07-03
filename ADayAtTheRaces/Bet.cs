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
            return "description";
        }

        public int PayOut()
        {
            int payout = 0;
            return payout;
        }
        
    }
}
