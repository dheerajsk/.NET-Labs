using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class LinearSearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 78, 56, 43, 84, 21, 06, 26, 74, 39, 18 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n\nEnter number to search");
            string input = Console.ReadLine();
            int numberToSearch = Convert.ToInt32(input);

            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                    flag = true;
                    Console.WriteLine(numberToSearch + " is found at position " + i);
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
