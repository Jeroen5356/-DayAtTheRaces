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
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomiser;
        public bool Race = true;

        public bool Run()
        {
            if(MyPictureBox == null)
            { 
        
                    int random = Randomiser.Next(5);
                    Location += random;
                    MyPictureBox.Left += Location + StartingPosition;
                    
                    
                
            }
            
           
        }
        public void TakeStartingPositions()
        {
            MyPictureBox.Left = 0;
        }
    }
}
