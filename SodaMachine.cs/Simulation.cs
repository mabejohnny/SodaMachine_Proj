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


                HowMuchToAddToRegister();

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

            SodaMachine.AcceptPaymentToRegister(amountChosen);

            customer.RemoveFundsFromWallet(amountChosen);
        }

       







    }
}
