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
        Dog[] raceDogs = new Dog[4];
        Bet[] placedBets = new Bet[3];
        Human selected;
        Dog ultimateWinner;
        public Form1()
        {
            InitializeComponent();
            
            guys[0] = new Human() { Name = "Joe", Cash = 50, MyLabel = joesInfo, MyRadioButton = joesRB };
            guys[1] = new Human() { Name = "Bob", Cash = 75, MyLabel = bobsInfo, MyRadioButton = bobsRB };
            guys[2] = new Human() { Name = "Al", Cash = 45, MyLabel = alsInfo, MyRadioButton = alsRB };

            raceDogs[0] = new Dog() { MyPictureBox = pictureBox1, LaneNumber = "1" };
            raceDogs[1] = new Dog() { MyPictureBox = pictureBox2, LaneNumber = "2" };
            raceDogs[2] = new Dog() { MyPictureBox = pictureBox3, LaneNumber = "3" };
            raceDogs[3] = new Dog() { MyPictureBox = pictureBox4, LaneNumber = "4" };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void raceButton_Click(object sender, EventArgs e)
        { for (int y = 0; raceDogs[y].Location < raceDogs[y].RacetrackLength; y++)
                {
                    raceDogs[y].Run();
                    if(y == 3)
                    {
                        y = -1; /// As somebody at work why x is must be -1 and not 0. is it because why is only incremented after loop is ran?
                    } 
                }
            Dog compareDogs;
            Dog compareDogs2;
            
            if (raceDogs[0].Location < raceDogs[1].Location)
                compareDogs = raceDogs[1];
            else
                compareDogs = raceDogs[0];
            
            if (raceDogs[2].Location < raceDogs[3].Location)
                compareDogs2 = raceDogs[3];
            else
                compareDogs2 = raceDogs[2];
            if (compareDogs.Location > compareDogs2.Location)
                ultimateWinner = compareDogs;
            else
                ultimateWinner = compareDogs2;

            MessageBox.Show("The winning dog is in lane number" + ultimateWinner.LaneNumber + ".");
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
        private void betAmountUpDown_ValueChanged(object sender, EventArgs e)
        {
            selected.MyBet = (int)betAmountUpDown.Value;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            //selected.MyLabel = 
        }
    }
}
