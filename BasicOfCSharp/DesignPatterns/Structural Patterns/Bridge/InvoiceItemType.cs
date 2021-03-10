using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    abstract class InvoiceItemType
    {
        protected string name;
        protected int qty;
        protected decimal rate;
        protected decimal price;

        public abstract decimal GetPrice();
        public abstract string GetName();
        public abstract int GetQty();
        public abstract decimal GetRate();

        public abstract void SetValues(string name, int qty, decimal rate, decimal price);
    }
}