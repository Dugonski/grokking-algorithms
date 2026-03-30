using System;
using System.Collections.Generic;

namespace Algorithms.Chapter02
{
    class SelectionSortProgram
    {
        public static int FindSmallest(List<int> arr)
        {
            int smallest = arr[0];
            int smallestIndex = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }

        public static List<int> SelectionSort(List<int> arr)
        {
            List<int> newArr = new List<int>();
            int originalLength = arr.Count;

            for (int i = 0; i < originalLength; i++)
            {
                int smallestIndex = FindSmallest(arr);
                newArr.Add(arr[smallestIndex]);
                arr.RemoveAt(smallestIndex);
                
                Console.WriteLine($"Old array: [{string.Join(", ", arr)}]");
                Console.WriteLine($"New array: [{string.Join(", ", newArr)}]\n");
            }

            return newArr;
        }

        public static void Main()
        {
            List<int> arr = new List<int> { 1, 3, 5, 7, 9, 14, 15, 16, 17, 18, 19, 20 };
            List<int> sortedArr = SelectionSort(arr);
            Console.WriteLine($"[{string.Join(", ", sortedArr)}]");
        }
    }
}
