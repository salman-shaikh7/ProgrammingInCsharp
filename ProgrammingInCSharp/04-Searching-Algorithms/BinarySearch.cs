using System;

namespace SearchingAlgorithms
{
    public class BinarySearch
    {
        public static void RunExample()
        {
            // Example sorted array
            int[] sortedArray = { 2, 3, 4, 10, 40, 50, 70 };

            Console.WriteLine("Array: ");
            PrintArray(sortedArray);

            int target = 10;

            // Perform Binary Search (Iterative)
            int iterativeResult = BinarySearchIterative(sortedArray, target);
            Console.WriteLine($"\nIterative Binary Search: Element {target} found at index {iterativeResult}");

            // Perform Binary Search (Recursive)
            int recursiveResult = BinarySearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);
            Console.WriteLine($"\nRecursive Binary Search: Element {target} found at index {recursiveResult}");
        }

        // 1. Iterative Binary Search Implementation
        private static int BinarySearchIterative(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Prevents overflow

                // Check if target is at mid
                if (arr[mid] == target)
                {
                    return mid; // Target found
                }

                // If target is greater, ignore the left half
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                // If target is smaller, ignore the right half
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Target not found
        }

        // 2. Recursive Binary Search Implementation
        private static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2; // Prevents overflow

                // Check if target is at mid
                if (arr[mid] == target)
                {
                    return mid; // Target found
                }

                // If target is smaller than mid, search the left half
                if (arr[mid] > target)
                {
                    return BinarySearchRecursive(arr, target, left, mid - 1);
                }

                // If target is greater than mid, search the right half
                return BinarySearchRecursive(arr, target, mid + 1, right);
            }

            return -1; // Target not found
        }

        // Utility function to print the array
        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // 3. Time Complexity Analysis
        public static void TimeComplexityAnalysis()
        {
            Console.WriteLine("\n-- Time Complexity of Binary Search --");
            Console.WriteLine("Best Case: O(1) - If the target is found at the middle index in the first comparison.");
            Console.WriteLine("Worst Case: O(log n) - Each step reduces the size of the search space by half.");
            Console.WriteLine("Average Case: O(log n) - On average, it takes log n comparisons to find the target.");
            Console.WriteLine("Space Complexity (Iterative): O(1) - No additional memory is used.");
            Console.WriteLine("Space Complexity (Recursive): O(log n) - Due to recursive calls and the call stack.");
        }
    }
}
