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
        public int MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabel()
        {
            //MyLabel.Text = //bet.description
            MyRadioButton.Text = Name + "has " + Cash + " pounds avaliable.";
        }

        public bool PlaceBet()
        {
            if (Cash > (Cash - MyBet))
            {
                Cash -= MyBet;
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
            MyBet = 0;
        }

        public void Collect()
        {
            ClearBet();
            Cash -= MyBet; //loss
            Cash += MyBet; //win
        }
    }
}
