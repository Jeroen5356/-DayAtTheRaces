using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Dog
    {
        public int StartingPosition = 45;
        public int RacetrackLength = 500;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomiser;
        public bool Race;
        public string LaneNumber;

        public void Run()
        {
                Random random = new Random();
                int paces = random.Next(0,30);
                MyPictureBox.Left += paces;
                Location = MyPictureBox.Left;
                System.Threading.Thread.Sleep(50);
        }
        public void TakeStartingPositions()
        {
            MyPictureBox.Left = StartingPosition;
        }
    }
}
