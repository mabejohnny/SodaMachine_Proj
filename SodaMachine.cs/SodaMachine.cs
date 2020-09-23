using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SodaMachine.cs
{
    class SodaMachine : Simulation
    {

        //member variables
        public List<Coin> register;
        public List<Can> inventory;

        public double changeToReturn;
        public double moneyInserted; 



        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            register.Add(new Coin("Quarters", 5.00));
            register.Add(new Coin("Dimes", 1.00));
            register.Add(new Coin("Nickles", 1.00));
            register.Add(new Coin("Pennies", 1.00));

            inventory = new List<Can>();
            inventory.Add(new Can("Cola", .35));
            inventory.Add(new Can("Root Beer", .60));
            inventory.Add(new Can("Orange", .6));

            this.changeToReturn = changeToReturn;
            this.moneyInserted = moneyInserted; 

        }




        //member methods

        public void ComparePaymentToCostOfItem(double moneyInserted, double Cost)
        {
            double changeToReturn = moneyInserted - Cost;

            foreach (Can item in inventory)
            {
                if(moneyInserted == item.Cost)
                {
                    AcceptPayment(); 
                    Console.WriteLine("Payment accepted!");
                    DispenseSoda();
                }
                else if(moneyInserted > item.Cost)
                {
                    Console.WriteLine("Not enough funds inserted!" + "\n" + "$ " + moneyInserted + " has been returned to your wallet");
                    ReturnFunds();

                }


            }


        }



        public void AcceptPayment() //take funds from wallet and put into register 
        {

        }



        public void DispenseSoda()
        {

        }

        public void ReturnFunds()
        {

        }





    }
}
