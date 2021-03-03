using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class SelectionSort
    {
        public static void Do()
        {
            int[] numbers = new int[5] { 7, 5, 3, 9, 1 };

            int smallest;
            int temp;
            Print(numbers);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                smallest = i;
                Console.WriteLine("\nIteration= " + i);
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallest])
                    {
                        smallest = j;
                    }
                }
                Console.WriteLine("\nVlaue of Smallest= " + numbers[smallest]);
                temp = numbers[smallest];
                numbers[smallest] = numbers[i];
                numbers[i] = temp;
                Print(numbers);
            }
        }

        private static void Print(int[] numbers)
        {
            foreach (int n in numbers)
            {
                Console.Write(n.ToString() + " ");
            }
        }
    }
}
