using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class ShellSort
    {
        public static void Do()
        {
            int[] numbers = new int[6] { 43, 87, 32, 09, 11, 54 };

            int arrayLength = numbers.Length;

            for (int gap = arrayLength / 2; gap > 0; gap /= 2)
            {
                Console.WriteLine("\nValue of gap is " + gap);
                for (int i = gap; i < arrayLength; i++)
                {
                    Print(numbers);
                    int valueForIteration = numbers[i];
                    Console.WriteLine("\nValue for iteration = " + valueForIteration);
                    int j;
                    for (j = i; (j >= gap && numbers[j - gap] > valueForIteration); j -= gap)
                    {
                        numbers[j] = numbers[j - gap];
                    }
                    Console.WriteLine("\nReplacing numbers[j] " + numbers[j] + " with valueForIteration " + valueForIteration);
                    numbers[j] = valueForIteration;
                    Print(numbers);
                }
            }
        }

        private static void Print(int[] numbers)
        {
            Console.WriteLine("");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
