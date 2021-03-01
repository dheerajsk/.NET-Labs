using System;
using System.Text;

namespace BasicOfCSharp
{
    class StringProgram
    {
        public static void Do()
        {
            string mary = "Mary had a little lamb.";
            Console.WriteLine("Original string = {0}", mary);
            Console.WriteLine("Clone of stirng = {0}", mary.Clone());
            Console.WriteLine("Compare of two strings = {0}", mary.CompareTo("Mary had a big lamb"));
            Console.WriteLine("Characters in a string={0}", mary.Contains("had"));
            Console.WriteLine("String ends with = {0}", mary.EndsWith("xyz"));
            Console.WriteLine("All lowercase = " + mary.ToLower());
            Console.WriteLine("All uppercase = " + mary.ToUpper());

            Console.WriteLine("Insert string within a string =" + mary.Insert(4, " and Jack"));
            string[] parts = mary.Split(" ");
            foreach (string p in parts)
            {
                Console.WriteLine(p);
            }

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
