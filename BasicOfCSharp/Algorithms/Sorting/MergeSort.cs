using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        public static void Do()
        {
            int[] numbers = { 12, 6, 11, 8, 6, 4 };
            Print(numbers);
            Divide(numbers, 0, numbers.Length - 1);
            Print(numbers);
        }

        private static void MergeAndSort(int[] numbers, int l, int m, int r)
        {
            int leftArraySize = m - l + 1;
            int rightArraySize = r - m;

            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];
            int i, j;
            for (i = 0; i < leftArraySize; i++)
            {
                leftArray[i] = numbers[l + i];
            }
            for (j = 0; j < rightArraySize; j++)
            {
                rightArray[j] = numbers[m + 1 + j];
            }
            Console.WriteLine("\nPrinting left array");
            Print(leftArray);
            Console.WriteLine("\nPrinting right array");
            Print(rightArray);
            i = j = 0;
            int k = l;
            while (i < leftArraySize && j < rightArraySize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    numbers[k] = leftArray[i];
                    i++;
                }
                else
                {
                    numbers[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArraySize)
            {
                numbers[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArraySize)
            {
                numbers[k] = rightArray[j];
                j++;
                k++;
            }
            Console.WriteLine("\nPrinting merged array");
            Print(numbers);
        }

        private static void Divide(int[] numbers, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            int m = l + (r - l) / 2;
            Divide(numbers, l, m);
            Divide(numbers, m + 1, r);
            MergeAndSort(numbers, l, m, r);
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
