using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    class InvoiceItem : InvoiceItemType
    {
        public override string GetName()
        {
            return name;
        }

        public override decimal GetPrice()
        {
            return price;
        }

        public override int GetQty()
        {
            return qty;
        }

        public override decimal GetRate()
        {
            return rate;
        }

        public override void SetValues(string name, int qty, decimal rate, decimal price)
        {
            this.name = name;
            this.qty = qty;
            this.rate = rate;
            this.price = price;
        }
    }
}
