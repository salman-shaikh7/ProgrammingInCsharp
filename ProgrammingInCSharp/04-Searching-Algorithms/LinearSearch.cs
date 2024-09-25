using System;

namespace SearchingAlgorithms
{
    public class LinearSearch
    {
        public static void RunExample()
        {
            // Example array to search
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Array: ");
            PrintArray(numbers);

            int target = 25;

            // Perform Linear Search
            int result = LinearSearchAlgorithm(numbers, target);
            if (result != -1)
            {
                Console.WriteLine($"\nLinear Search: Element {target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"\nLinear Search: Element {target} not found");
            }
        }

        // 1. Linear Search Algorithm Implementation
        private static int LinearSearchAlgorithm(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // Target found, return the index
                }
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

        // 2. Time Complexity Analysis
        public static void TimeComplexityAnalysis()
        {
            Console.WriteLine("\n-- Time Complexity of Linear Search --");
            Console.WriteLine("Best Case: O(1) - The target is found at the first index.");
            Console.WriteLine("Worst Case: O(n) - The algorithm must check all elements.");
            Console.WriteLine("Average Case: O(n) - On average, the algorithm will check half the elements.");
            Console.WriteLine("Space Complexity: O(1) - No additional memory is used.");
        }
    }
}
