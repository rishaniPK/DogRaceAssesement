using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //To Add the toolbox elements to class

namespace DogRace
{
    // //abstarct the bet class in to person class
    class Person :bet
    {
        private string name;
        // The guy’s name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int cash;
        // How much cash he has
        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        private bet myBet;
        //An instance of Bet() that has his bet
        public bet MyBet
        {
            get { return myBet; }
            set { myBet = value; }
        }

        private RadioButton myRadioButton;
        // my radio button variable
        public RadioButton MyRadioButton
        {
            get { return myRadioButton; }
            set { myRadioButton = value; }
        }

        private Label myLabel;
        // my lable as variable
        public Label MyLabel
        {
            get { return myLabel; }
            set { myLabel = value; }
        }
        
        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my radio button to show my cash
            // as (raavan has 35$)
            this.myRadioButton.Text = this.name + " has " + this.cash.ToString() + " dollar";
            // calling the GetDescription from the bet class tp show to stuffs inthe lable 
            this.myLabel.Text = this.myBet.GetDescription();
        }

        //winningDogNo is a parameter from main form1
        public void Collect(int winningDogNo)
        {
            // Ask my bet to pay out
            if (this.cash > 0)
                this.cash += this.myBet.Payout(winningDogNo);
        }
        // Reset my bet so it’s zero
        public void ClearBet()
        {
            this.myBet.Amount = 0;
            this.myRadioButton.Text = this.name + " has " + this.cash + " dollar";
            this.myLabel.Text = this.name + " hasn't placed any bet";
        }
        //parameter of amount anf dognumber from main form1
        public bool PlaceBet(int amount, int dogNumber)
        {
            if (amount < this.cash)
            {
                // Place a new bet and store it in my bet field
                this.myBet = new bet() { Amount = amount, DogNumber = dogNumber, Bettor = this };
                UpdateLabels();
                // Return true if the guy had enough money to bet
                return true;
            }
            return false;
        }
    }
}
