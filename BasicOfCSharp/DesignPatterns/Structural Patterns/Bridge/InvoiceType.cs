using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    abstract class InvoiceType
    {
        protected string id;
        protected string customer;
        protected List<InvoiceItemType> _items;

        public abstract void AddItem(InvoiceItemType item);
        public abstract void SetCustomer(string name);
        public abstract void SetId(string id);
        public abstract List<InvoiceItemType> GetItems();
        public abstract decimal GetTotal();
    }
}
