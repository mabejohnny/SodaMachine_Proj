using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine.cs
{
    class SodaMachine : Simulation
    {

        //member variables
        public List<Coin> register;
        public List<Can> inventory;



        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            register.Add(new Coin());

            inventory = new List<Can>();
            inventory.Add(new Can());

        }




        //member methods
        public void PerformTransaction()
        {

        }





    }
}
