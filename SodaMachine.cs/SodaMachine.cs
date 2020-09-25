using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
            CreateRegister();

            inventory = new List<Can>();
            CreateInventory();

            this.changeToReturn = changeToReturn;
            this.moneyInserted = moneyInserted;
            hasEnoughChange = true;

          
        }


        //member methods


        public void CreateRegister()
        {
            for (int i = 0; i < 12; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Nickle());
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());
            }

        }

        public void CreateInventory()
        {
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new Cola());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new OrangeSoda());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new RootBeer());
            }
        }
        

        public void AcceptPaymentToRegister(string amountToAdd) 
        {
            if(amountToAdd == "1")
            {
                for (int i = 0; i < 4; i++)
                {   
                    register.Add(new Quarter());

                }
                
            }
            else if(amountToAdd == "2")
            {
                for (int i = 0; i < 8; i++)
                {
                    register.Add(new Quarter());

                }


            }
            else if (amountToAdd == "2")
            {
                for (int i = 0; i < 12; i++)
                {
                    register.Add(new Quarter());

                }


            }



        }


        public void CheckToSeeIfThereIsEnoughMoneyInWallet(string amountChosen)
        {
            if(amountChosen == "1")
            {
                amountChosen += 1.00;

                if(amountChosen < //total in wallet )
                {
                    Console.WriteLine("Error!  There is not enough money in your wallet to complete this transaction");

                }

            }
            else if (amountChosen == "2")
            {
                amountChosen += 2.00;

            }
            else if (amountChosen == "3")
            {
                amountChosen += 3.00;

            }







            foreach (Can item in inventory)
            {

                if (moneyInserted == item.Cost)
                {
                    AcceptPayment(moneyInserted);
                    Console.WriteLine("Payment accepted!");
                    DispenseSoda(purchasedCan);
                }
                else if (moneyInserted > item.Cost)
                {
                    Console.WriteLine("Not enough funds inserted!" + "\n" + "$ " + moneyInserted + " has been returned to your wallet");
                    //CalculateReturnChange(moneyInserted);

                }
                else if (moneyInserted < item.Cost && hasEnoughChange == true)
                {
                    Console.WriteLine("Payment accepted");
                    Console.WriteLine("Please wait for your change");
                    DispenseSoda(purchasedCan);
                    //CalculateReturnChange(moneyInserted);
                }
                else
                {
                    Console.WriteLine("Error! Machine low on change" + "\n" + "Please insert exact change and try again!");

                }


            }


        }

        public void DispenseSoda(string purchasedCan)
        {
            //foreach (Can item in inventory)
            //{
            //if(purchasedCan)
            //{
            //Console.WriteLine("Dispensing Soda");

            //}
            //else if()
            //{

            //}


            //}



            //}

            //public void RemoveItemFromInventory()
            //{

            //}

            //public void AddItemToBackPack(Can cans)
            //{
            //backpack.products.Add(cans);


            //}


            //public double CalculateReturnChange(double moneyInserted)
            //{
            //double changeToReturn = moneyInserted -

            //if (changeToReturn < 0)
            //{
            //changeToReturn = 0;
            //}

            //return changeToReturn;
            //}



        }

    }

}