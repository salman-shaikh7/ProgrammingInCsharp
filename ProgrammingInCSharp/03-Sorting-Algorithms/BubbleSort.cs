using System;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void RunExample()
        {
            // Example array to sort
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            // Perform Bubble Sort
            BubbleSortAlgorithm(numbers);

            Console.WriteLine("\nSorted Array:");
            PrintArray(numbers);
        }

        // 1. Bubble Sort Algorithm Implementation
        private static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Flag to detect if any swapping occurs in this iteration
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare adjacent elements
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap if the current element is greater than the next
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                // If no swapping happens in this pass, the array is already sorted
                if (!swapped)
                {
                    break;
                }

                Console.WriteLine($"After pass {i + 1}:");
                PrintArray(arr);
            }
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
            Console.WriteLine("\n-- Time Complexity of Bubble Sort --");
            Console.WriteLine("Best Case (Already Sorted Array): O(n)");
            Console.WriteLine("Average Case: O(n^2)");
            Console.WriteLine("Worst Case: O(n^2)");
            Console.WriteLine("Space Complexity: O(1) (In-place Sorting)");
        }
    }
}
