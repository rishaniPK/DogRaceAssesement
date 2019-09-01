using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    //abstarct the hound class in to bet class
    class bet:Hound
    {
        private int amount;
        //Defining a variable and get the value and set them 
        // The amount of cash that was bet
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private int dogNumber;
        //The number of the dog the bet is on
        public int DogNumber
        {
            get { return dogNumber; }
            set { dogNumber = value; }
        }

        private Person bettor;
        // The person who placed the bet
        public Person Bettor
        {
            get { return bettor; }
            set { bettor = value; }
        }
        // methode to display the description in the lable
        public string GetDescription()
        {
            if (this.amount == 0) // mean initially user doesnot have any money or bet placed
                return this.bettor.Name + " hasn't placed any bet";
            else // else return what he placed and on what dog
                return this.bettor.Name + " placed " + this.bettor.MyBet.amount.ToString() + " dollar on dog # " + this.bettor.MyBet.DogNumber.ToString();
        }
        //The parameter is the winningDogNo of the race. 
        public int Payout(int winningDogNo)
        {
            /*If the dog won,
         return the amount bet. Otherwise, return the negative of
        the amount bet. */
            if (this.bettor.MyBet.DogNumber == winningDogNo)
                return this.amount;
            else
                return -this.amount;
        }
    }
}
