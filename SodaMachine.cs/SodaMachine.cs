﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SodaMachine.cs
{
    class SodaMachine
    {

        public List<Coin> register;
        public List<Can> inventory;


        public SodaMachine()
        {
            register = new List<Coin>();
            CreateRegister();

            inventory = new List<Can>();
            CreateInventory();
        }



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

        public double TotalInserted(List<Coin> coins)
        {
            double total = 0;

            foreach (Coin item in coins)
            {
                total += item.Value;
            }
            return total;
        }

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
                    register.Add(new Quarter());
            }
            if (amountchosen == 2)
            {
                register.Add(new Dime());
            }
            if (amountchosen == 3)
            {
                register.Add(new Nickle());
            }
            if (amountchosen == 4)
            {
                register.Add(new Penny());
            }
        }

        public bool CheckInventory(string sodaName)
        {
            foreach (Can item in inventory)
            {
                if (item.name == sodaName)  
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

        public bool CheckChange(double change, double moneyInRegister)
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

        public double ReturnSodaPrice(string sodaChoice)
        {
            foreach (Can item in inventory)
            {
                if(item.name == sodaChoice)
                {
                    return item.Cost;
                }

            }
            return 0.00;

        }

    }

}