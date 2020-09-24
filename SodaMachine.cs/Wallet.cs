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
            coins.Add(new Coin("Quarters", 2.75));
            coins.Add(new Coin("Dimes", .50));
            coins.Add(new Coin("Nickles", 1.75));

        }


        //member methods






    }
}
