using System;
using System.Collections.Generic;
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
                return userChoiceMainMenu;  //GetUserInfoFromMainMenu(); 

            }
            else
            {
                Console.WriteLine(" * Error! Please Try Again * ");
                MainMenu();
            }



        }

        public void HowMuchToAddToRegister() 
        {
            Console.WriteLine("Please select from the following options: " + "\n" + "\n" + "  1] $ 1.00" + "\n" + "   2]  $ 2.00" + "\n" + "   3]  $ 3.00");
            string amountChosen = Console.ReadLine();

            CheckToSeeIfThereIsEnoughMoneyInWallet(amountChosen);


            //SodaMachine.AcceptPaymentToRegister(amountChosen);

            //customer.RemoveFundsFromWallet(amountChosen);
        }

        public void CheckToSeeIfThereIsEnoughMoneyInWallet(string amountChosen)
        {
            if (amountChosen == "1")
            {
                amountChosen += 1.00;

                if (amountChosen < //how to compare to whats in wallet )    //not enough in wallet
                {
                    Console.WriteLine("Error!  There is not enough money in your wallet to complete this transaction");
                    UserInterface.MainMenu();

                }
                else if(amountChosen >= //money in wallet )   //more then enough in wallet
                {
                    customer.RemoveFundsFromWallet(amountChosen);

                }
                 
            }
            else if (amountChosen == "2")
            {
                amountChosen += 2.00;

                if (amountChosen < //how to compare to whats in wallet )    //not enough in wallet
                {
                    Console.WriteLine("Error!  There is not enough money in your wallet to complete this transaction");
                    UserInterface.MainMenu();

                }
                else if (amountChosen >= //money in wallet )   //more then enough in wallet
                {
                    customer.RemoveFundsFromWallet(amountChosen);

                }

            }
            else if (amountChosen == "3")
            {
                amountChosen += 3.00;

                if (amountChosen < //how to compare to whats in wallet )    //not enough in wallet
                {
                    Console.WriteLine("Error!  There is not enough money in your wallet to complete this transaction");
                    UserInterface.MainMenu();

                }
                else if (amountChosen >= //money in wallet )   //more then enough in wallet
                {
                    customer.RemoveFundsFromWallet(amountChosen);

                }

            }









        }
}
