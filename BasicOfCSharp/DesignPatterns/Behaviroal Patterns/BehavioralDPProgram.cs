using DesignPatterns.Behaviroal_Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns
{
    class BehavioralDPProgram
    {
        public static void Do()
        {
            Console.WriteLine("== Observer Pattern ==");
            Tesla tesla = new Tesla("Tesla", 700.00M);
            tesla.AddWatcher(new Person("Person 1", tesla));
            tesla.AddWatcher(new Person("Person 2", tesla));
            tesla.AddWatcher(new Person("Person 3", tesla));
            Console.WriteLine(tesla.SetPrice(800));
        }
    }
}
