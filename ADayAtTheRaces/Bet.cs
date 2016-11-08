using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int Totalbets;

        public Bet(Human bettor, int amount, Dog whichDog)
        {
            Bettor = bettor;
            Amount = amount;
            WhichDog = whichDog;
            Totalbets++;
        }

        public string GetDescription()
        {
            return Bettor.Name + " bets " + Amount + " on dog #" + WhichDog.LaneNumber;
        }

        public void PayOut(Dog winner)
        {
            if(winner == WhichDog)
            {
                //First give the bettor his money back
                Bettor.Cash += Amount;
                //Double the bet amount and add it to his cash
                Bettor.Cash += (Amount * 2);
                outcomeLabelWinner();
            }
            else
            {
                outcomeLabelLoser();
            }
            
        }

        public void outcomeLabelLoser()
        {
            //Change the text color to red
            Bettor.MyOutcomeLabel.ForeColor = Color.FromArgb(255, 11, 11);
            Bettor.MyOutcomeLabel.Text = "(-" + Bettor.MyBet.Amount + ")";
        }

        public void outcomeLabelWinner()
        {
            //Change the text color to green
            Bettor.MyOutcomeLabel.ForeColor = Color.FromArgb(11, 255, 28);
            Bettor.MyOutcomeLabel.Text = "(+" + Bettor.MyBet.Amount*2 + ")";
        }

    }
}
