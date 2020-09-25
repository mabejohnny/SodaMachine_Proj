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
        SodaMachine SodaMachine = new SodaMachine();
        Customer customer = new Customer();
        





        //constructor
        public Simulation()
        {

        }




        //member methods
        public void GetUserInfoFromMainMenu(string userChoiceMainMenu)
        {
            if (userChoiceMainMenu == "1")
            {

                HowMuchToAddToRegister();//check to see how mcuh they want to insert

            }
            else if (userChoiceMainMenu == "2" || userChoiceMainMenu == "3")
            {
                ;  //GetUserInfoFromMainMenu(); 

            }
   

        }

        public void HowMuchToAddToRegister()
        {
            Console.WriteLine("Please select from the following options: " + "\n" + "\n" + "  1] $ 1.00" + "\n" + "   2]  $ 2.00" + "\n" + "   3]  $ 3.00");
            double moneyAdded = int.Parse(Console.ReadLine()); Console.ReadLine();

            CompareMoneyPassedIn(moneyAdded);


            //SodaMachine.AcceptPaymentToRegister(amountChosen);

            //customer.RemoveFundsFromWallet(amountChosen);
        }

        

        public static void BrowseInventory( List<Can> inventory, Can can)
        {
            string sodaChoice = UserInterface.SelectProduct();
            foreach (Can item in inventory)
            {
                if(sodaChoice == item.name)
                {
                    SodaMachine.RemoveFromMachineInventory(sodaChoice); //what is the problem here?
                   
                }
                

            }
        }
       




    }
}
