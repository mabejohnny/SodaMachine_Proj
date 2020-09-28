using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine.cs
{
    class Wallet 
    {
     

       public List<Coin> coins;
       public Card card = new Card();
        

        public Wallet()
        {
            coins = new List<Coin>();
            CreateWallet();
        }

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

        public void RemoveFundsFromWallet(string amountChosen)
        {
            if (amountChosen == "1")
            {
                for (int i = 0; i < 4; i++)
                {
                    coins.Remove(new Quarter());
                }
            }
            else if(amountChosen == "2")
            {
                for (int i = 0; i < 8; i++)
                {
                    coins.Remove(new Quarter());
                }
            }
            else if(amountChosen == "3")
            {
                for (int i = 0; i < 12; i++)
                {
                    coins.Remove(new Quarter());
                }
            }
            
        }
    }
}
