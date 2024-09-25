using System;

namespace BigOExamples
{
    public class BigOExamples
    {
        public static void RunExamples()
        {
            // O(1) - Constant Time Example
            Console.WriteLine("\nO(1) - Constant Time:");
            ConstantTimeExample();

            // O(n) - Linear Time Example
            Console.WriteLine("\nO(n) - Linear Time:");
            LinearTimeExample();

            // O(log n) - Logarithmic Time Example
            Console.WriteLine("\nO(log n) - Logarithmic Time:");
            LogarithmicTimeExample();

            // O(n^2) - Quadratic Time Example
            Console.WriteLine("\nO(n^2) - Quadratic Time:");
            QuadraticTimeExample();
        }

        // O(1) - Constant Time
        // Example: Accessing an element in an array by index
        private static void ConstantTimeExample()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int index = 2;
            int element = arr[index]; // Constant time array access
            Console.WriteLine($"Element at index {index}: {element}");
        }

        // O(n) - Linear Time
        // Example: Traversing an array with a loop
        private static void LinearTimeExample()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array elements:");
            for (int i = 0; i < arr.Length; i++) // Linear time traversal
            {
                Console.WriteLine(arr[i]);
            }
        }

        // O(log n) - Logarithmic Time
        // Example: Binary search in a sorted array
        private static void LogarithmicTimeExample()
        {
            int[] sortedArr = { 10, 20, 30, 40, 50, 60, 70 };
            int target = 40;
            int result = BinarySearch(sortedArr, target);
            if (result != -1)
            {
                Console.WriteLine($"Element {target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found");
            }
        }

        // Binary Search implementation for O(log n) example
        private static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid; // Target found
                }

                if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return -1; // Target not found
        }

        // O(n^2) - Quadratic Time
        // Example: A simple bubble sort implementation
        private static void QuadraticTimeExample()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            BubbleSort(arr); // O(n^2) sorting algorithm

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        // Bubble Sort implementation for O(n^2) example
        private static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
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
    }
}
