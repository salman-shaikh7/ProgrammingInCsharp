using System;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void RunExample()
        {
            // Example array to sort
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            // Perform Quick Sort
            QuickSortAlgorithm(numbers, 0, numbers.Length - 1);

            Console.WriteLine("\nSorted Array:");
            PrintArray(numbers);
        }

        // 1. Quick Sort Algorithm Implementation
        private static void QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the subarrays on either side of the pivot
                QuickSortAlgorithm(arr, low, pivotIndex - 1); // Sort left side
                QuickSortAlgorithm(arr, pivotIndex + 1, high); // Sort right side
            }
        }

        // Partition function - returns the index of the pivot element after placing it in its correct position
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choosing the last element as the pivot
            int i = low - 1; // Index of the smaller element

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j); // Swap the smaller element with the element at i
                }
            }

            // Place the pivot in its correct position by swapping it with the element at i+1
            Swap(arr, i + 1, high);
            return i + 1; // Return the pivot index
        }

        // Swap function to exchange elements
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
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

        // 2. Time Complexity Analysis
        public static void TimeComplexityAnalysis()
        {
            Console.WriteLine("\n-- Time Complexity of Quick Sort --");
            Console.WriteLine("Best Case: O(n log n) - occurs when the pivot divides the array evenly.");
            Console.WriteLine("Average Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n^2) - occurs when the pivot is the smallest or largest element, resulting in unbalanced partitions.");
            Console.WriteLine("Space Complexity: O(log n) due to recursion (stack space).");
        }
    }
}
