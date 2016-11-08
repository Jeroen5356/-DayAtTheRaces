using System.Windows.Forms;
using System.Threading;

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
        public static int Totalbets;

        public Human(string name, int cash, Label mylabel, RadioButton myradiobutton, Label myoutcomelabel)
        {
            Name = name;
            Cash = cash;
            MyLabel = mylabel;
            MyRadioButton = myradiobutton;
            MyOutcomeLabel = myoutcomelabel;
        }

        public void UpdateLabel()
        {
            MyRadioButton.Text = Name + "has " + Cash + " pounds avaliable.";
        }

        public bool PlaceBet(int amount, Dog whichDog)
        {
            if (Cash - amount >= 0)
            {
                Interlocked.Increment(ref Totalbets);
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

        public bool checkForThreeBets()
        {
            if (Totalbets == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearBet()
        {
            MyBet = null;
            MyLabel.Text = "";
            Totalbets = 0;
        }
    }
}
