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
    class Dog
    {
        public int RacetrackLength = 500;
        public PictureBox MyPictureBox;
        public int StartingPositionX;
        public int StartingPositionY;
        public int Location = 0;
        public int LaneNumber;
        private Random random;
        private int paces;

        public void Run()
        {
            StartingPositionX = MyPictureBox.Location.X;
            StartingPositionY = MyPictureBox.Location.Y;

            random = new Random();
            paces = random.Next(0,30);

            Location = MyPictureBox.Left + paces;
            System.Threading.Thread.Sleep(50);
        }

        public void TakeStartingPositions()
        {
            MyPictureBox.Location = new Point(StartingPositionX, StartingPositionY);
            MyPictureBox.Left = 45;
            Location = 0;
        }
    }
}
