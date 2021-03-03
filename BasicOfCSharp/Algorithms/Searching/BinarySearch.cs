using System;

namespace Algorithms.Searching
{
    class BinarySearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 06, 18, 21, 26, 39, 43, 56, 74, 78, 84 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n\nEnter number to search");
            string input = Console.ReadLine();
            int numberToSearch = Convert.ToInt32(input);

            int indexFound = -1;
            int minNum = 0;
            int maxNum = numbers.Length - 1;

            while (minNum <= maxNum && indexFound == -1)
            {
                int midElement = (minNum + maxNum) / 2;
                Console.Write("Min - "+numbers[minNum]+"  ");
                Console.Write("Mid - " + numbers[midElement] + "  ");
                Console.Write("Max - " + numbers[maxNum] + "\n");
                if (numberToSearch == numbers[midElement])
                {
                    indexFound = ++midElement;
                    break;
                }
                else if (numberToSearch < numbers[midElement])
                {
                    maxNum = midElement - 1;
                }
                else
                {
                    minNum = midElement + 1;
                }
            }

            if (indexFound > -1)
            {
                Console.WriteLine("Found number at posiiton " + indexFound);
            }

        }
    }
}
