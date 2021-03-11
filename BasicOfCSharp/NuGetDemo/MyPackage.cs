using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetDemo
{
    public class MyPackage
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }
        public void DisplayDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
