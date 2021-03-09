using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    class CreationDPProgram
    {
        public static void Do()
        {
            Console.WriteLine("==Abstract Factory Pattern==");
            MyKitchen k = new MyKitchen();
            k.CreateItems();
            var items = k.GetItems();
            foreach (KitchenItem item in items)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
