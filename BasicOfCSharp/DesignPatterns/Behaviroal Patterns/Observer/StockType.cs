using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.Observer
{
    abstract class StockType
    {
        private string name;
        private decimal price;

        private List<Watcher> watchers = new List<Watcher>();

        public StockType(string _name, decimal _price)
        {
            name = name;
            price = _price;
        }

        public void AddWatcher(Watcher w)
        {
            watchers.Add(w);
        }

        public void RemoveWatcher(Watcher w)
        {
            watchers.Remove(w);
        }

        public void SendNotification()
        {
            foreach (Watcher w in watchers)
            {
                w.Notify(this);
            }
        }

        public string SetPrice(decimal p)
        {
            this.price = p;
            SendNotification();
            return "Price changed to " + p.ToString();
        }

        public string getName() { return name; }
        public decimal getPrice() { return price; }
    }
}
