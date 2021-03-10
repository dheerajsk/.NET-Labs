using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    class Invoice : InvoiceType
    {
        public Invoice()
        {
            _items = new List<InvoiceItemType>();
        }
        public override void AddItem(InvoiceItemType item)
        {
            _items.Add(item);
        }

        public override List<InvoiceItemType> GetItems()
        {
            return _items;
        }

        public override decimal GetTotal()
        {
            decimal total = 0.00M;
            foreach (InvoiceItemType i in this._items)
            {
                total += i.GetPrice();
            }
            return total;
        }

        public override void SetCustomer(string name)
        {
            this.customer = name;
        }

        public override void SetId(string id)
        {
            this.id = id;
        }
    }
}
