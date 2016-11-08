using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{

    class Human
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyOutcomeLabel;

        public void UpdateLabel()
        {
            MyRadioButton.Text = Name + "has " + Cash + " pounds avaliable.";
        }

        public bool PlaceBet(int amount, Dog whichDog, Human bettor)
        {
            if (Cash > (Cash - amount))
            {
                MyBet = new Bet(this, amount, whichDog);
                Cash -= MyBet.Amount;
                MyLabel.Text = MyBet.GetDescription();
                return true;
            }
            else
            {
                MessageBox.Show("You cannot place a bet of this amount.");
                return false;
            }
        }

        public void ClearBet()
        {
            MyBet = null;
            MyLabel.Text = "";
        }
    }
}
