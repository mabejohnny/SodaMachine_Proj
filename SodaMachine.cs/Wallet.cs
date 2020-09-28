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
                coins.Remove(new Quarter());
            }
            if (amountChosen == "2")
            {
                coins.Remove(new Dime());
            }
            if (amountChosen == "3")
            {
                coins.Remove(new Nickle());
            }
            if (amountChosen == "4")
            {
                coins.Remove(new Penny());
            }

        }
    }
}

