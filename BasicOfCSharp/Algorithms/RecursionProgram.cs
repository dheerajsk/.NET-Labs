using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RecursionProgram
    {
        public static void Do()
        {
            int[] numbers = new int[20] { 43, 65, 12, 90, 42, 11, 58, 32, 29, 40, 58, 71, 62, 07, 40, 28, 19, 28, 37, 46 };
            Print(numbers, 0);
            Console.WriteLine("\n Recursion has been completed");
        }

        private static void Print(int[] numbers, int currentElementIndex)
        {
            Console.WriteLine(numbers[currentElementIndex]);
            if (currentElementIndex < numbers.Length - 1)
            {
                Print(numbers, currentElementIndex + 1);
            }
        }
    }
}
