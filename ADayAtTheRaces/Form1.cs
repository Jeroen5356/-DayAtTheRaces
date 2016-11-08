using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Human[] guys = new Human[3];
        Dog[] raceDogs = new Dog[5];
        Human selected;
        Dog ultimateWinner;
        public Form1()
        {
            InitializeComponent();

            guys[0] = new Human("Joe", 50, joesInfo, joesRB, joesOutcomeLabel);
            guys[1] = new Human("Bob", 75, bobsInfo, bobsRB, bobsOutcomeLabel);
            guys[2] = new Human("Al", 45, alsInfo, alsRB, AlsOutcomeLabel);

            raceDogs[1] = new Dog() { MyPictureBox = pictureBox1, LaneNumber = 1 };
            raceDogs[2] = new Dog() { MyPictureBox = pictureBox2, LaneNumber = 2 };
            raceDogs[3] = new Dog() { MyPictureBox = pictureBox3, LaneNumber = 3 };
            raceDogs[4] = new Dog() { MyPictureBox = pictureBox4, LaneNumber = 4 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            joesRB.Text = guys[0].Name + " has " + guys[0].Cash + " bucks";
            bobsRB.Text = guys[1].Name + " has " + guys[1].Cash + " bucks";
            alsRB.Text = guys[2].Name + " has " + guys[2].Cash + " bucks";

            MinimumBetLabel.Text = "Minimum bet: " + Convert.ToString(betAmountUpDown.Minimum)+ " bucks";
            joesInfo.Text = "Joe hasn't made a bet.";
            bobsInfo.Text = "Bob hasn't made a bet.";
            alsInfo.Text = "Al hasn't made a bet.";
        }

        public void raceButton_Click(object sender, EventArgs e) {
            if (guys[2].checkForThreeBets())
            {
                for (int y = 1; raceDogs[y].Location < raceDogs[y].RacetrackLength; y++)
                {
                    raceDogs[y].Run();
                    if (y == 4)
                    {
                        y = 0;
                    }
                }
                Dog compareDogs;
                Dog compareDogs2;

                if (raceDogs[1].Location < raceDogs[2].Location)
                    compareDogs = raceDogs[2];
                else
                    compareDogs = raceDogs[1];

                if (raceDogs[3].Location < raceDogs[4].Location)
                    compareDogs2 = raceDogs[4];
                else
                    compareDogs2 = raceDogs[3];
                if (compareDogs.Location > compareDogs2.Location)
                    ultimateWinner = compareDogs;
                else
                    ultimateWinner = compareDogs2;

                MessageBox.Show("The winning dog is in lane number " + ultimateWinner.LaneNumber + ".");
                foreach (Human guy in guys)
                {
                    guy.MyBet.PayOut(ultimateWinner);
                    guy.ClearBet();
                }
                //Get the updated information from the bettors
                joesRB.Text = guys[0].Name + " has " + guys[0].Cash + " bucks";
                bobsRB.Text = guys[1].Name + " has " + guys[1].Cash + " bucks";
                alsRB.Text = guys[2].Name + " has " + guys[2].Cash + " bucks";

                //Place the dogs back to their starting positions
                for (int i = 1; i <= 4; i++)
                {
                    raceDogs[i].TakeStartingPositions();
                }
            }
            else
            {
                MessageBox.Show("All the guys should place a bet, this game is not for pussies");
            }
            
        }

        private void joesRB_CheckedChanged(object sender, EventArgs e)
        {
            selected = guys[0];
            varNameLabel.Text = guys[0].Name; 
        }

        private void bobsRB_CheckedChanged(object sender, EventArgs e)
        {
            selected = guys[1];
            varNameLabel.Text = guys[1].Name;
        }

        private void alsRB_CheckedChanged(object sender, EventArgs e)
        {
            selected = guys[2];
            varNameLabel.Text = guys[2].Name;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
                selected.PlaceBet(Convert.ToInt16(betAmountUpDown.Value), raceDogs[Convert.ToInt16(laneUpDown.Value)]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
