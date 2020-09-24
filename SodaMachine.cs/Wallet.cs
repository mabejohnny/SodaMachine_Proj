using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine.cs
{
    class Wallet 
    {
        //member variables
        List<Coin> coins;
        Card card = new Card();
        



        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
            CreateWallet();
            
           

        }


        //member methods

        public void CreateWallet()
        {
            for (int i = 0; i < 11; i++)
            {
                coins.Add(new Quarter());
            }
            for (int i = 0; i < 11; i++)
            {
                coins.Add(new Dime());
            }
            for (int i = 0; i < 11; i++)
            {
                coins.Add(new Nickle());
            }
        }

        public void AcceptPaymentToWallet()
        {

        }





    }
}
