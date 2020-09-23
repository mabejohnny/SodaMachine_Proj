using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine.cs
{
    class Wallet : Customer 
    {
        //member variables
        List<Coin> coins;
        Card card = new Card();
        



        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
            coins.Add(new Coin());

        }


        //member methods






    }
}
