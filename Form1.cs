using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; //To Add the toolbox elements of form
using System.Threading;

namespace DogRace
{
    public partial class RaceBet : Form
    {
        public RaceBet()
        {
            InitializeComponent();
        }

        public object Payout(int v)
        {
            throw new NotImplementedException();
        }

        //Calling the class Person, Hound and assigned the array as listofguys, listofdogs as null
        private Person[] listOfGuys = null;
        private Hound[] listOfDogs = null;
        //defining a variable as flag to check the radio button as persons
        private int flag = 0;
        //defining a variable to Race button to enable and disable
        private bool enableRaceBtn = false;

        //constructor to fill the array
        public void FillArrays()
        {
            //defining an object as myRandom
            Random myRandom = new Random();

            //allocating  array for 3 person (interger)
            listOfGuys = new Person[3]
            {
                //1st array person
                new Person()
                {
                     // calling the varibales from the class person
                    Name = "shaan",
                    Cash = 50,
                    MyBet = new bet(), 
                    MyLabel = lbl_person1,
                    MyRadioButton = rb_person1 
                },
                //2nd array person
                new Person()
                {
                // calling the varibales from the class person
                    Name = "Ravan",
                    Cash = 50,
                    MyBet = new bet(), 
                    MyLabel = lbl_person2,
                    MyRadioButton = rb_person2 
                },
                //3rd array person
                new Person()
                {
                    // calling the varibales from the class person
                    Name = "Abira",
                    Cash = 50,
                    MyBet = new bet(), 
                    MyLabel = lbl_person3,
                    MyRadioButton = rb_person3
                }
            };
            //allocating  array for 4 dog (interger)
            listOfDogs = new Hound[4]
            {
                //1st array dog
                new Hound()
                {
                    //varibles from the class Hound 
                    RaceTrackLength = PbRace.Width - 80,
                    StartingPosition = PbRace.Location.X,
                    MyRandom = myRandom,
                    MyPictureBox = pb_dog1
                },
                //2nd array of dog
                new Hound()
                {
                    //varibles from the class Hound
                    RaceTrackLength = PbRace.Width - 80,
                    StartingPosition = PbRace.Location.X,
                    MyRandom = myRandom,
                    MyPictureBox = pb_dog2
                },
                //3rd array of dog
                new Hound()
                {
                    //varibles from the class Hound
                    RaceTrackLength = PbRace.Width - 80,
                    StartingPosition = PbRace.Location.X,
                    MyRandom = myRandom,
                    MyPictureBox = pb_dog3
                },
                // 4th array of dog
                new Hound()
                {
                    //varibles from the class Hound
                    RaceTrackLength = PbRace.Width - 80,
                    StartingPosition = PbRace.Location.X,
                    MyRandom = myRandom,
                    MyPictureBox = pb_dog4
                }
            };
            // variable i is as to increment of people who bet
            for (int i = 0; i < listOfGuys.Length; i++)
            {
                listOfGuys[i].MyBet.Bettor = listOfGuys[i];
                //calling the methode from the class person (UpdateLables)
                listOfGuys[i].UpdateLabels();
            }
            // to start the game 
            PlaceDogPicturesAtStart();
        }
        //fucntion when the form load
        private void RaceBet_Load(object sender, EventArgs e)
        {
            // The minimun value of numbericupdown is 5
            try
            {
                if (nud_money.Value == 5)
                   lbl_miniMoney.Text = "Minimum limit : 5$";
                //callling the methode
                FillArrays();
                //button Race is disable
                if (!this.enableRaceBtn)
                    btn_startRace.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Rb_person1_CheckedChanged(object sender, EventArgs e)
        {
            //radio button is checked with the person 1
            if (rb_person1.Checked)
            {
                this.flag = 1;
                lbl_PersonName.Text = this.listOfGuys[0].Name;
            }
        }
        private void Rb_person2_CheckedChanged(object sender, EventArgs e)
        {
            //radio button is checked with the person 2
            if (rb_person2.Checked)
            {
                this.flag = 2;
                lbl_PersonName.Text = this.listOfGuys[1].Name;
            }
        }
        private void Rb_person3_CheckedChanged(object sender, EventArgs e)
        {
            //radio button is checked with the person 3
            if (rb_person3.Checked)
            {
                this.flag = 3;
                lbl_PersonName.Text = this.listOfGuys[2].Name;
            }
        }
        //Methode to work with the bet button
        public void BetsButtonWorking()
        {
            //Variable money and dognumber to select the amount and the dog number
            int money = 0;
            int dogNumber = 0;
            // if you not checked any person you cannt bet 
            if (!rb_person1.Checked && !rb_person2.Checked && !rb_person3.Checked)
            {
                MessageBox.Show("You must choose atleast one guy to place bet.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // coverting the variavle money and dognumber into int of the numericupdown of 
            //value of money and selecting the number at the dog to bet
            money = Convert.ToInt32(nud_money.Value);
            dogNumber = Convert.ToInt32(nud_NoOfDog.Value);

            //calling the methode as not to bet more than 15 dollar in one dog
            if (IsExceedBetLimit(money))
            {
                MessageBox.Show("You can't put money greater than 15 on dog.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            enableRaceBtn = true; // if at least one bet is placed enable race button 

            // if the radio button One is checked you need to select the amount to bet and
            // the which number of dog you bet
            if (this.flag == 1)
            {
                this.listOfGuys[0].PlaceBet(money, dogNumber);
            }
            // if the radio button second is checked you need to select the amount to bet and
            // the which number of dog you bet
            else if (this.flag == 2)
            {
                this.listOfGuys[1].PlaceBet(money, dogNumber);
            }
            // if the radio button Third is checked you need to select the amount to bet and
            // the which number of dog you bet
            else if (this.flag == 3)
            {
                this.listOfGuys[2].PlaceBet(money, dogNumber);
            }
        }
        private void Lbl_PersonName_Click(object sender, EventArgs e)
        {}
        private void Btn_bet_Click(object sender, EventArgs e)
        {
            try
            {
                //calling the methode of enabling the bet button
                BetsButtonWorking();
                // if the button is enable you can start the race
                if (this.enableRaceBtn)
                    btn_startRace.Enabled = true; // Race button enable 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // methode to find the maximum limit to bet on a dog
        public bool IsExceedBetLimit(int amount)
        {
            // if the varable amount is less than 15 and greather than 5 
            // the statment is ture else its false
            if (amount > 15 && amount > 5)
                return true;

            return false;
        }
        // methode to enable the race button 
        public void RaceButtonWorking()
        {
            // button bet and Race disable before betting 
            btn_bet.Enabled = false;
            btn_startRace.Enabled = false;

            // Variable bool winning dog and person
            bool winnerDogFlag = false;
            int winningDogNo = 0;

            while (!winnerDogFlag)
            {
                for (int i = 0; i < listOfDogs.Length; i++)
                {
                    if (this.listOfDogs[i].Run())
                    {
                        winnerDogFlag = true;
                        winningDogNo = i;
                    }

                    PbRace.Refresh(); // refreshing picture boxes of dogs to start new
                }
            }
            MessageBox.Show("We have a winner - dog # " + (winningDogNo + 1) + "!", "Race Over");

            for (int j = 0; j < listOfGuys.Length; j++)
            {
                this.listOfGuys[j].Collect(winningDogNo + 1); // collecting the bets
                this.listOfGuys[j].ClearBet(); // clearing all bets
            }
            //calling the methode  PlaceDogPicturesAtStart()
            PlaceDogPicturesAtStart();
            btn_bet.Enabled = true;
        }
        // methode to start the game PlaceDogPictureAtStart
        public void PlaceDogPicturesAtStart()
        {
            //When variable k is less than 0 the dog in the list as at length with increment by 1 
            for (int k = 0; k < listOfDogs.Length; k++)
                //allocating an array of the value of k to the start point methode
                listOfDogs[k].TakeStartingPosition();
        }
        // click button on race to start race
        private void Btn_startRace_Click(object sender, EventArgs e)
        {
            // if you select the bet and cash then only can able to click the Race button
            try
            {
                RaceButtonWorking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void Pb_dog1_Click(object sender, EventArgs e)
        {
        }
        private void GbBettingDetails_Enter(object sender, EventArgs e)
        {
        }
    }
}

