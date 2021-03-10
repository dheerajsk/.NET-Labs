using DesignPatterns.Structural_Patterns.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns
{
    class StructuralDPProgram
    {
        public static void Do()
        {
            Console.WriteLine(" == Adapter Pattern == ");
            India india = new India(new WorkAbroad());
            Console.WriteLine(india.StartWork());

            Console.WriteLine(" == Bridge Pattern == ");
            Invoice invoice = new Invoice();
            invoice.SetCustomer("Acem");
            invoice.SetId("AES77");

            InvoiceItem item1 = new InvoiceItem();
            item1.SetValues("Item 1", 1, 45, 70);
            invoice.AddItem(item1);
            InvoiceItem item2 = new InvoiceItem();
            item2.SetValues("Item 2", 10, 35, 700);
            invoice.AddItem(item2);
            InvoiceItem item3 = new InvoiceItem();
            item3.SetValues("Item 3", 5, 57, 90);
            invoice.AddItem(item3);
            Console.WriteLine("Invoice Total=" + invoice.GetTotal());
        }
    }
}
