using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        public static void Do()
        {
            int[] numbers = new int[5] { 7, 5, 3, 9, 1 };

            int valueForIteration;
            Print(numbers);

            for (int i = 1; i < numbers.Length; i++)
            {
                valueForIteration = numbers[i];
                Console.WriteLine("\nIterating for value - " + valueForIteration);

                for (int j = i - 1; j >= 0;)
                {
                    var swapIndex = j;
                    if (valueForIteration < numbers[j])
                    {
                        numbers[j + 1] = numbers[j];
                        swapIndex--;
                        numbers[swapIndex + 1] = valueForIteration;
                        Console.WriteLine("Moving " + valueForIteration);
                        Print(numbers);
                    }
                    j--;
                }
            }
        }

        public static void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}
