using System;

namespace Algorithms.Chapter03
{
    class RecursiveBinarySearchProgram
    {
        public static int? RecursiveBinarySearch(int[] lst, int item)
        {
            if (lst.Length == 0)
            {
                return null;
            }

            int mid = lst.Length / 2;
            int guess = lst[mid];

            if (guess == item)
            {
                return mid;
            }

            if (guess > item)
            {
                return RecursiveBinarySearch(lst[..mid], item);
            }
            else
            {
                return RecursiveBinarySearch(lst[(mid + 1)..], item);
            }
        }

        public static void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(RecursiveBinarySearch(arr, 15));
        }
    }
}
