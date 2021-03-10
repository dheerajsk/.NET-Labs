using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.Observer
{
    class Person : Watcher
    {
        private string name;
        private Tesla tesla;

        public Person(string name, Tesla st)
        {
            this.name = name;
            this.tesla = st;
        }
        public void Notify(StockType type)
        {
            Console.WriteLine("Stock price " + type.getName() + " is now " + type.getPrice());
        }
    }
}
