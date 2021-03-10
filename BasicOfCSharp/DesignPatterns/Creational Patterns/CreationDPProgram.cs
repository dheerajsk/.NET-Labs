using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    class CreationDPProgram
    {
        public static void Do()
        {
            Console.WriteLine("== Abstract Factory Pattern ==");
            MyKitchen k = new MyKitchen();
            k.CreateItems();
            var items = k.GetItems();
            foreach (KitchenItem item in items)
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine("== Singleton Pattern ==");
            ThisApplication app1 = ThisApplication.Instance();
            app1.SetName("App 1");
            Console.WriteLine(app1.getName());
            ThisApplication app2 = ThisApplication.Instance();
            app2.SetName("App 2");
            Console.WriteLine(app2.getName());
            Console.WriteLine(app1.getName() + " == " + app2.getName());

            Console.WriteLine("== Prototype Pattern ==");
            BookingType seat1 = new Booking();
            seat1.SetSeat("14b");
            Console.WriteLine(seat1.GetSeat());
            BookingType seat2 = seat1.Clone();
            Console.WriteLine(seat2.GetSeat());
        }
    }
}
