using System;

namespace Algorithms.Chapter01
{
    class BinarySearchProgram
    {
        public static int? BinarySearch(int[] lst, int item)
        {
            int low = 0;
            int high = lst.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = lst[mid];

                if (guess == item)
                {
                    Console.WriteLine($"Item found at index {mid}");
                    return mid;
                }

                if (guess > item)
                {
                    Console.WriteLine($"Item not found at index {mid}");
                    high = mid - 1;
                }
                else
                {
                    Console.WriteLine($"Item not found at index {mid}");
                    low = mid + 1;
                }
            }

            return null;
        }

        public static void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(BinarySearch(arr, 15));
        }
    }
}
