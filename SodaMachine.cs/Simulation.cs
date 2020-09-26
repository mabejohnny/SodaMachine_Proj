using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SodaMachine.cs
{
    class Simulation
    {


        //member variables
        SodaMachine sodaMachine = new SodaMachine();
        Customer customer = new Customer();

        public List<Can> inventory;
        public List<Coin> register;






        //constructor
        public Simulation()
        {

        }


        public void RunMachine()
        {
            while (true)
            {
                UserInterface.MainMenu();
                UserInterface.HowMuchDoughYouSportingDog(); 
                //browse inventory 

            }
        }




        //member methods

    
      

        public void CompareMoneyPassedIn(double moneyAdded, Can can)
        {
            foreach (Can item in inventory)
            {   
                if (moneyAdded > item.Cost)
                {
                    sodaMachine.RefundMoney(moneyAdded);
                    

                }
                else if (moneyAdded == item.Cost || moneyAdded < item.Cost)
                {
                    sodaMachine.AcceptPaymentToRegister(moneyAdded);
                    sodaMachine.CalculateChange(moneyAdded, can);
                    


                }

            }
        }



        public void BrowseInventory(List<Can> inventory, Can can)
        {
            string sodaChoice = UserInterface.SelectProduct();
            foreach (Can item in inventory)
            {
                if(sodaChoice == item.name)
                {
                    
                    sodaMachine.RemoveFromMachineInventory(item);
                   
                   
                }
                

            }
        }
       




    }
}
