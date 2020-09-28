using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SodaMachine.cs
{
    public class Coin 
    {
   
        public string name;
        
        public double Value
        {
            get
            {
                return value;
            }
        }
        protected double value;

    }
}
