using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SodaMachine.cs
{
    class SodaMachine
    {

        //member variables
        public List<Coin> register;
        public List<Can> inventory;

        public double changeToReturn;
        public double moneyInserted;
        public bool hasEnoughChange;



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
            hasEnoughChange = true;

        }




        //member methods






        public void ComparePaymentToCostOfItem(double moneyInserted, double Cost)
        {
            double changeToReturn = moneyInserted - Cost;

            foreach (Can item in inventory)
            {
                
                if (moneyInserted == item.Cost)
                {
                    AcceptPayment(moneyInserted);
                    Console.WriteLine("Payment accepted!");
                    DispenseSoda();
                }
                else if (moneyInserted > item.Cost)
                {
                    Console.WriteLine("Not enough funds inserted!" + "\n" + "$ " + moneyInserted + " has been returned to your wallet");
                    CalculateReturnChange(moneyInserted);

                }
                else if (moneyInserted < item.Cost && hasEnoughChange == true)
                {
                    Console.WriteLine("Payment accepted");
                    Console.WriteLine("Please wait for your change");
                    DispenseSoda();
                    CalculateReturnChange(moneyInserted);
                }
                else
                {
                    Console.WriteLine("Error! Machine low on change" + "\n" + "Please insert exact change and try again!");

                }


            }


        }



        public void AcceptPayment(double moneyInserted) //take funds from wallet and put into register 
        {

            register.Add(new Coin(moneyInserted)); //takes in 2 arguments. how can I do this differently 

        }



        public void DispenseSoda()
        {
            Console.WriteLine();
            

        }

        public double CalculateReturnChange(double moneyInserted)
        {
            double changeToReturn = moneyInserted - 

            if (changeToReturn < 0)
            {
                changeToReturn = 0;
            }

            return changeToReturn;
        }
            
        

    }
    
}
