using System;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        public static void Do()
        {
            int[] numbers = new int[] { 9, -1, 3, 0, 56, 21, 32, 91, 43, 71 };
            Sort(numbers, 0, numbers.Length - 1);
        }

        private static void Sort(int[] numbers, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                Console.WriteLine("Left = {0}, Right = {1}", left, right);
                PrintSubArray(numbers, left, right);
                pivot = Partition(numbers, left, right);
                Console.WriteLine("\nPivot number=" + numbers[pivot]+"\n");
                if (pivot > 1)
                {
                    Sort(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(numbers, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot;
            pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                //Console.WriteLine("Left = {0}, Right = {1}", left, right);
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                    Print(numbers);
                }
                else
                {
                    return right;
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
            Console.WriteLine("");
        }

        private static void PrintSubArray(int[] numbers, int left, int right)
        {
            Console.WriteLine("");
            for (int i = left; i <= right; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
