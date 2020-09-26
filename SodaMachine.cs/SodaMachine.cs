using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SodaMachine.cs
{
    class SodaMachine
    {

        //member variables
        public List<Coin> register;
        public List<Can> inventory;





        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            CreateRegister();

            inventory = new List<Can>();
            CreateInventory();


        }


        //member methods


        public void CreateRegister()
        {
            for (int i = 0; i < 12; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Nickle());
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());
            }

        }

        public void CreateInventory()
        {
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new Cola());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new OrangeSoda());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new RootBeer());
            }
        }

        //public double method. foreach through wallet, return back
        //If enough money is not passed in, don’t complete transaction and give the money back. 

        public bool EnoughMoneyForPurchase(double moneyCustomerPaid, Can canSelected)
        {
            if (moneyCustomerPaid > canSelected.Cost)
            {
                return true;
            }
            return false;
        }

        public void ReturnMoneyToCustomer(List<Coin> coinsGivenByCustomer, Customer customer)
        {
            customer.wallet.coins.AddRange(coinsGivenByCustomer);
        }



        public void AcceptPaymentToRegister(double amountchosen)
        {
            if (amountchosen == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    register.Add(new Quarter());

                }

            }
            else if (amountchosen == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    register.Add(new Quarter());

                }


            }
            else if (amountchosen == 3)
            {
                for (int i = 0; i < 12; i++)
                {
                    register.Add(new Quarter());

                }
            }
        }

        public bool SufficientInventory(Can can)
        {
            foreach (Can item in inventory)
            {
                if (can.name == item.name)  
                {
                    return true;

                }
                else
                {
                    return false;


                }
            }
            return false;

        }

        public bool EnoughChange(double change, double moneyInRegister)
        {
            if (moneyInRegister > change)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculateChange(double moneyAdded, Can can)
        {
            double change;
            change = moneyAdded - can.Cost;
            return change;
        }

        public double MoneyInRegister()
        {
            double moneyInRegister = 0;
            foreach (Coin item in register)
            {
                moneyInRegister += item.Value;
            }
            return moneyInRegister;
        }

        public double RefundMoney(double moneyAdded)
        {
            double refundedMoney;
            refundedMoney = moneyAdded;

            return refundedMoney;

        }


        public void RemoveFromMachineInventory(Can newCan)
        {
            inventory.Remove(newCan);

        }

       

        

    }

}