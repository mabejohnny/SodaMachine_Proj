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

        public Coin RemoveCoinFromWalletIntoMachine(string searchingFor)
        {
            foreach (Coin item in wallet.coins)
            {
                if (item.name == searchingFor)
                {
                    wallet.coins.Remove(item);
                    return item;
                }

            }
            return null; //I dont know what else to put here...Its expecting one eitherway?


        }

        public bool CheckWalletForFunds(string searchingFor)
        {
            foreach (Coin item in wallet.coins)
            {
                if (item.name == searchingFor)
                {
                    return true;
                }
            }
            return false;

        }
    }
}

