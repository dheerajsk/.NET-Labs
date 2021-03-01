using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfCSharp
{
    class FlowControl
    {
        public static void Do()
        {
            var a = 300;

            if (a == 100)
            {
                Console.WriteLine("Value of a is 100");
            }
            else if (a == 200)
            {
                Console.WriteLine("Value of a is 200");
            }
            else
            {
                Console.WriteLine("Value of a is not 100 and 200");
            }
            DoLoops();
        }

        private static void DoLoops()
        {
            // 1. While loop
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            for (int i = counter; i < 20; i++)
            {
                counter = i;
                Console.WriteLine(counter);
            }

            do
            {
                Console.WriteLine(counter);
                counter++;

            } while (counter < 30);

            int[] array = { 10, 20, 30, 40, 50 };
            Console.WriteLine("\n For each loop \n");
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }

        }
    }
}
