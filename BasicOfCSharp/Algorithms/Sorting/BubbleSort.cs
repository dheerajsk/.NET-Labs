using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        public static void Do()
        {
            string[] names = new string[5];
            names[0] = "Mark";
            names[1] = "Shah";
            names[2] = "Srivastava";
            names[3] = "Dubey";
            names[4] = "Singh";

            string temp;
            Print(names);
            for (int i = 1; i < names.Length - 1; i++)
            {
                Console.WriteLine("\n\nStarting Pass " + i.ToString());
                Print(names);
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j + 1].CompareTo(names[j]) < 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                        Console.WriteLine("\nSwapped");
                        Print(names);
                    }
                }
            }
            Print(names);
        }

        private static void Print(string[] names)
        {
            Console.WriteLine("");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
        }
    }
}
