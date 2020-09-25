using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace SodaMachine.cs
{
    class Customer 
    {

        //member variables
        public BackPack backpack = new BackPack();
        public Wallet wallet = new Wallet();
        public string purchasedCan;
        public List<Can> cans;




        //constructor
        public Customer()
        {
            

        }



        //member methods
        public void AddToBackPack(string itemPurchased, Can can)
        {
            foreach (Can item in cans)
            {
                if (itemPurchased == item.name)
                {
                    backpack.cans.Add(item);
                }
            }



        }






    }
}
