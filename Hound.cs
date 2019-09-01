using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; //To Add the toolbox elements to class

namespace DogRace
{
    public class Hound // class of hound
    {
        // Variable of starting the position of dog (the picturebox start)
        private int startingPosition;
        //get and set property is used to get the value and return a new value
        //to the variable at the start position again
        public int StartingPosition
        {
            get { return startingPosition; }
            set { startingPosition = value; }
        }
        // Variable of the length of the racetrack
        private int raceTrackLength;
        //get and set property is used to get the value and return a new value
        //to the variable at the start position again
        public int RaceTrackLength
        {
            get { return raceTrackLength; }
            set { raceTrackLength = value; }
        }

        private int location;
         // Variable of location on the racetrack 
        public int Location
        //get and set property is used to get the value and return a new value
        //to the variable at the start position again
        {
            get { return location; }
            set { location = value; }
        }
        //Variable for picture box as object
        private PictureBox myPictureBox;

        public PictureBox MyPictureBox
        {
            //get and set property is used to get the value and return a new value
            //to the variable at the start position again
            get { return myPictureBox; }
            set { myPictureBox = value; }
        }

        private Random myRandom;
        //varible to get a random number
        public Random MyRandom
        {
            //get and set property is used to get the value and return a new value
            //to the variable at the start position again
            get { return myRandom; }
            set { myRandom = value; }
        }

        // Methode of Run as bool
        public bool Run()
        {
            //Variable randomDistance is equal to the variable in class hound and getting
            // a dog 1, 2, 3 or 4 to  move forward
            int randomDistance = this.myRandom.Next(1, 4);
            this.location += randomDistance;

            // Point is found in System.Drawing. as inbuild library 
            Point p = this.myPictureBox.Location; // to get the current location of the picturebox

            if (p.X > this.raceTrackLength)
            {
                return true;
            }
            else
            {
                p.X += randomDistance; // add the value to move forward to its  X coordination
                this.myPictureBox.Location = p; // update the picturebox in the form

                return false;
            }
        }
        public void TakeStartingPosition()
        {
            this.location = this.startingPosition;

            Point p = this.myPictureBox.Location;
            p.X = Location;
            this.myPictureBox.Location = p;// update the picturebox in the form
        }

        public object MRandom(int v)
        {
            throw new NotImplementedException();
        }
    }
}
