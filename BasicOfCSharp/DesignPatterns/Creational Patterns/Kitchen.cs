using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    abstract class Kitchen
    {
        protected List<KitchenItem> items = new List<KitchenItem>();

        public List<KitchenItem> GetItems()
        {
            return items;
        }

        public abstract void CreateItems();
    }
}
