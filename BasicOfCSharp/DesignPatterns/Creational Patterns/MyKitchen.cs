using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    class MyKitchen : Kitchen
    {
        public override void CreateItems()
        {
            items.Add(new Spoon());
            items.Add(new Glass());
            items.Add(new Kettle());
            items.Add(new Pan());
        }
    }
}
